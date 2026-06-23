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
    public partial class LeaveManagement : Form
    {
        public LeaveManagement()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string EmployeeNumber = txtEmployeeNumber.Text.Trim();

            if (string.IsNullOrEmpty(EmployeeNumber))
            {
                MessageBox.Show("Please enter an Employee Number.");
                return;
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\E137138_Programming\E137138_Programming\Grifindo.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT EmployeeType, AnnualLeaves, CasualLeaves, ShortLeaves FROM Employee WHERE EmployeeNumber = @EmployeeNumber";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cmbEmployeeType.SelectedItem = reader["EmployeeType"].ToString();
                    txtAnnualLeaves.Text = reader["AnnualLeaves"].ToString();
                    txtCasualLeaves.Text = reader["CasualLeaves"].ToString();
                    txtShortLeaves.Text = reader["ShortLeaves"].ToString();
                }
                else
                {
                    MessageBox.Show("Employee not found.");
                }
            }
        }

        private void cmbEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string EmployeeType = cmbEmployeeType.SelectedItem.ToString();

                // Default values for leaves
                if (EmployeeType == "Permanent Employee")
                {
                    txtAnnualLeaves.Text = "14";  
                    txtCasualLeaves.Text = "7"; 
                    txtShortLeaves.Text = "2";   
                }
                else if (EmployeeType == "Newly Joined Employee")
                {
                    txtAnnualLeaves.Text = "10"; 
                    txtCasualLeaves.Text = "5";  
                    txtShortLeaves.Text = "2";   
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                string EmployeeNumber = txtEmployeeNumber.Text.Trim();
                string EmployeeType = cmbEmployeeType.SelectedItem.ToString();
                int AnnualLeaves = int.Parse(txtAnnualLeaves.Text);
                int CasualLeaves = int.Parse(txtCasualLeaves.Text);
                int ShortLeaves = int.Parse(txtShortLeaves.Text);

                if (string.IsNullOrEmpty(EmployeeNumber))
                {
                    MessageBox.Show("Please enter an Employee Number.");
                    return;
                }

                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\E137138_Programming\E137138_Programming\Grifindo.mdf;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Employee SET EmployeeType = @EmployeeType, AnnualLeaves = @AnnualLeaves, CasualLeaves = @CasualLeaves, ShortLeaves = @ShortLeaves WHERE EmployeeNumber = @EmployeeNumber";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmployeeType", EmployeeType);
                    cmd.Parameters.AddWithValue("@AnnualLeaves", AnnualLeaves);
                    cmd.Parameters.AddWithValue("@CasualLeaves", CasualLeaves);
                    cmd.Parameters.AddWithValue("@ShortLeaves", ShortLeaves);
                    cmd.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Leave details updated successfully!");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Page obj = new Admin_Page();
            obj.Show();
        }

        private void btnLoadRoaster_Click(object sender, EventArgs e)
        {
            string EmployeeNumber = txtEmployeeNumber.Text.Trim();
            if (!string.IsNullOrEmpty(EmployeeNumber))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\E137138_Programming\E137138_Programming\Grifindo.mdf;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "SELECT RoasterStartTime, RoasterEndTime FROM Employee WHERE EmployeeNumber = @EmployeeNumber";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Check for NULL before setting the DateTimePicker values
                        if (reader["RoasterStartTime"] == DBNull.Value)
                        {
                            MessageBox.Show("Roaster Start Time is not set for this employee.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dtpStartTime.Value = DateTime.Now; // Or any default value
                        }
                        else
                        {
                            dtpStartTime.Value = Convert.ToDateTime(reader["RoasterStartTime"]);
                        }

                        if (reader["RoasterEndTime"] == DBNull.Value)
                        {
                            MessageBox.Show("Roaster End Time is not set for this employee.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dtpEndTime.Value = DateTime.Now; // Or any default value
                        }
                        else
                        {
                            dtpEndTime.Value = Convert.ToDateTime(reader["RoasterEndTime"]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter an Employee Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnUpdateRoaster_Click(object sender, EventArgs e)
        {
            string EmployeeNumber = txtEmployeeNumber.Text.Trim();
            DateTime RoasterStartTime = dtpStartTime.Value;
            DateTime RoasterEndTime = dtpEndTime.Value;

            // Validation to ensure EndTime is later than StartTime
            if (RoasterEndTime <= RoasterStartTime)
            {
                MessageBox.Show("End Time must be later than Start Time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if validation fails
            }

            if (!string.IsNullOrEmpty(EmployeeNumber))
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\E137138_Programming\E137138_Programming\Grifindo.mdf;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "UPDATE Employee SET RoasterStartTime = @RoasterStartTime, RoasterEndTime = @RoasterEndTime WHERE EmployeeNumber = @EmployeeNumber";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber);
                    cmd.Parameters.AddWithValue("@RoasterStartTime", RoasterStartTime);
                    cmd.Parameters.AddWithValue("@RoasterEndTime", RoasterEndTime);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Roaster timing updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update roaster timing. Please check the Employee Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter an Employee Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadPendingLeaves()
        {
            string query = "SELECT LeaveID, EmployeeNumber, LeaveType, StartDate, EndDate, Status FROM Leave WHERE Status = 'Pending'";
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\E137138_Programming\E137138_Programming\Grifindo.mdf;Integrated Security=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPendingLeaves.DataSource = dt;
            }
        }

        private void tbPageLeaveApproval_Click(object sender, EventArgs e)
        {

        }

        private void LeaveManagement_Load(object sender, EventArgs e)
        {
            LoadPendingLeaves();
        }

        private void dgvPendingLeaves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvPendingLeaves_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                // Ensure the click is not on the header row
                if (e.RowIndex >= 0)
                {
                    // Get the selected row
                    DataGridViewRow row = dgvPendingLeaves.Rows[e.RowIndex];

                    // Populate the text boxes
                    txtLeaveID.Text = row.Cells["LeaveID"].Value.ToString();
                    txtEmployeeNumber1.Text = row.Cells["EmployeeNumber"].Value.ToString();
                    txtLeaveType.Text = row.Cells["LeaveType"].Value.ToString();
                    txtStartDate.Text = row.Cells["StartDate"].Value.ToString();
                    txtEndDate.Text = row.Cells["EndDate"].Value.ToString();
                    txtStatus.Text = row.Cells["Status"].Value.ToString();
                }
            }
        }

        private void dgvPendingLeaves_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txtLeaveID.Text))
                {
                    MessageBox.Show("Please select a leave application to approve.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update the Status to "Approved"
                string query = "UPDATE Leave SET Status = 'Approved' WHERE LeaveID = @LeaveID";
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\E137138_Programming\E137138_Programming\Grifindo.mdf;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LeaveID", txtLeaveID.Text);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Leave application approved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPendingLeaves(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to approve leave application. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txtLeaveID.Text))
                {
                    MessageBox.Show("Please select a leave application to reject.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update the Status to "Rejected"
                string query = "UPDATE Leave SET Status = 'Rejected' WHERE LeaveID = @LeaveID";
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\E137138_Programming\E137138_Programming\Grifindo.mdf;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LeaveID", txtLeaveID.Text);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Leave application rejected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPendingLeaves(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to reject leave application. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
