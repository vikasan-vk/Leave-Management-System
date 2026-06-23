using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E137138_Programming
{
    public partial class LeaveStatus : Form
    {
        private string LoggedInEmployeeNumber;

        public LeaveStatus(string EmployeeNumber)
        {
            InitializeComponent();
            LoggedInEmployeeNumber = EmployeeNumber;
        }
        

        private void LeaveStatus_Load(object sender, EventArgs e)
        {
            try
            {
                // Your connection string
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\E137138_Programming\E137138_Programming\Grifindo.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Query to fetch leave details for the logged-in employee
                    string query = "SELECT LeaveType, StartDate, EndDate, Status FROM Leave WHERE EmployeeNumber = @EmployeeNumber";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmployeeNumber", LoggedInEmployeeNumber);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    dgvLeaveStatus.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading leave status: " + ex.Message);
            }
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Page obj = new Employee_Page (LoggedInEmployeeNumber);
            obj.Show();
        }

        private void btnDeleteLeave_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (dgvLeaveStatus.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvLeaveStatus.SelectedRows[0];

                    // Check if the row is not null and has valid data
                    if (selectedRow.Cells["Status"].Value != null)
                    {
                        string status = selectedRow.Cells["Status"].Value.ToString();
                        if (status == "Pending")
                        {
                            DialogResult result = MessageBox.Show("Are you sure you want to cancel this leave?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                // Delete logic
                                string leaveType = selectedRow.Cells["LeaveType"].Value.ToString();
                                string startDate = selectedRow.Cells["StartDate"].Value.ToString();

                                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\E137138_Programming\E137138_Programming\Grifindo.mdf;Integrated Security=True";
                                using (SqlConnection conn = new SqlConnection(connectionString))
                                {
                                    conn.Open();
                                    string deleteQuery = "DELETE FROM Leave WHERE EmployeeNumber = @EmployeeNumber AND LeaveType = @LeaveType AND StartDate = @StartDate AND Status = 'Pending'";
                                    SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                                    cmd.Parameters.AddWithValue("@EmployeeNumber", LoggedInEmployeeNumber);
                                    cmd.Parameters.AddWithValue("@LeaveType", leaveType);
                                    cmd.Parameters.AddWithValue("@StartDate", startDate);

                                    int rowsAffected = cmd.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Leave canceled successfully!");
                                        RefreshLeaveStatusGrid();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to cancel leave. Please try again.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("You can only cancel leaves with 'Pending' status.", "Cancel Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected row is invalid. Please select a valid leave request.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to cancel the leave.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while canceling the leave. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshLeaveStatusGrid()
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\E137138_Programming\E137138_Programming\Grifindo.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT LeaveType, StartDate, EndDate, Status FROM Leave WHERE EmployeeNumber = @EmployeeNumber";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmployeeNumber", LoggedInEmployeeNumber);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvLeaveStatus.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing leave status: " + ex.Message);
            }
        }
    }
}
