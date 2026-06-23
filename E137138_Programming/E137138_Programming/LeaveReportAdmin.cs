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
    public partial class LeaveReportAdmin : Form
    {
        public LeaveReportAdmin()
        {
            InitializeComponent();
        }

        private void LeaveReportAdmin_Load(object sender, EventArgs e)
        {
            dgvLeaveReports.DataSource = null; // Start with an empty grid
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            {
                // Get input values
                string EmployeeNumber = txtEmployeeNumber.Text.Trim();
                DateTime StartDate = dtpStartDate.Value.Date;
                DateTime EndDate = dtpEndDate.Value.Date;

                // Validate date range
                if (StartDate > EndDate)
                {
                    MessageBox.Show("Start date cannot be after the end date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // SQL Query
                string query;
                if (string.IsNullOrEmpty(EmployeeNumber))
                {
                    // All employees
                    query = "SELECT LeaveID, EmployeeNumber, LeaveType, StartDate, EndDate, Status " +
                            "FROM Leave WHERE StartDate >= @StartDate AND EndDate <= @EndDate";
                }
                else
                {
                    // Specific employee
                    query = "SELECT LeaveID, EmployeeNumber, LeaveType, StartDate, EndDate, Status " +
                            "FROM Leave WHERE EmployeeNumber = @EmployeeNumber AND StartDate >= @StartDate AND EndDate <= @EndDate";
                }

                // Load data into the DataGridView
                LoadLeaveReport(query, EmployeeNumber, StartDate, EndDate);
            }
        }
        private void LoadLeaveReport(string query, string EmployeeNumber, DateTime StartDate, DateTime EndDate)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\E137138_Programming\E137138_Programming\Grifindo.mdf;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@StartDate", StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", EndDate);

                    if (!string.IsNullOrEmpty(EmployeeNumber))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvLeaveReports.DataSource = dt;
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Page obj = new Admin_Page();
            obj.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear the Employee Number TextBox
            txtEmployeeNumber.Text = string.Empty;

            // Reset the DateTimePickers to today's date
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;

            // Clear the DataGridView
            dgvLeaveReports.DataSource = null;
        }

        private void lblEmployeeNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
