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
    public partial class LeaveAplication : Form
    {
        private string LoggedInEmployeeNumber;

        public LeaveAplication(string EmployeeNumber)
        {
            InitializeComponent();
            LoggedInEmployeeNumber = EmployeeNumber;
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\E137138_Programming\E137138_Programming\Grifindo.mdf;Integrated Security=True");

        private void LeaveAplication_Load(object sender, EventArgs e)
        {

        }

        private void btnLeaveSubmit_Click(object sender, EventArgs e)
        {
            string employeeNumber = txtEmployeeNumber.Text;
            string leaveType = cmbLeaveType.SelectedItem?.ToString();
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            // Validation
            if (string.IsNullOrEmpty(employeeNumber) || string.IsNullOrEmpty(leaveType))
            {
                MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the employee exists in the database
            string checkEmployeeQuery = "SELECT COUNT(*) FROM Employee WHERE EmployeeNumber = @EmployeeNumber";
            SqlCommand checkCmd = new SqlCommand(checkEmployeeQuery, con);
            checkCmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);

            con.Open();
            int employeeExists = (int)checkCmd.ExecuteScalar();
            con.Close();

            if (employeeExists == 0)
            {
                MessageBox.Show("Invalid Employee Number. Please check and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate leave rules
            if (leaveType == "Annual" && (startDate - DateTime.Now).TotalDays < 7)
            {
                MessageBox.Show("Annual leave must be applied at least 7 days in advance.", "Invalid Leave", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (leaveType == "Short" && (endDate - startDate).TotalMinutes != 90)
            {
                MessageBox.Show("Short leave duration must be exactly 1 hour and 30 minutes.", "Invalid Leave", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for overlapping leaves
            string checkOverlapQuery = "SELECT COUNT(*) FROM Leave WHERE EmployeeNumber = @EmployeeNumber AND " +
                                       "((StartDate <= @EndDate AND EndDate >= @StartDate) AND Status != 'Rejected')";
            SqlCommand overlapCmd = new SqlCommand(checkOverlapQuery, con);
            overlapCmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);
            overlapCmd.Parameters.AddWithValue("@StartDate", startDate);
            overlapCmd.Parameters.AddWithValue("@EndDate", endDate);

            con.Open();
            int overlapExists = (int)overlapCmd.ExecuteScalar();
            con.Close();

            if (overlapExists > 0)
            {
                MessageBox.Show("The selected leave dates overlap with an existing leave application.", "Overlap Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Fetch remaining leaves for the employee
            string balanceQuery = "SELECT AnnualLeaves, CasualLeaves, ShortLeaves FROM Employee WHERE EmployeeNumber = @EmployeeNumber";
            SqlCommand balanceCmd = new SqlCommand(balanceQuery, con);
            balanceCmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);

            con.Open();
            SqlDataReader reader = balanceCmd.ExecuteReader();
            if (reader.Read())
            {
                int remainingAnnualLeaves = Convert.ToInt32(reader["AnnualLeaves"]);
                int remainingCasualLeaves = Convert.ToInt32(reader["CasualLeaves"]);
                int remainingShortLeaves = Convert.ToInt32(reader["ShortLeaves"]);

                // Calculate the number of leave days requested
                int totalDays = (endDate - startDate).Days + 1; // Include start and end dates

                // Validate leave quotas
                if (leaveType == "Annual" && totalDays > remainingAnnualLeaves)
                {
                    con.Close();
                    MessageBox.Show("You don't have enough annual leaves remaining.", "Leave Quota Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (leaveType == "Casual" && totalDays > remainingCasualLeaves)
                {
                    con.Close();
                    MessageBox.Show("You don't have enough casual leaves remaining.", "Leave Quota Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (leaveType == "Short" && remainingShortLeaves <= 0)
                {
                    con.Close();
                    MessageBox.Show("You have used all your short leaves for this month.", "Leave Quota Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                con.Close();
                MessageBox.Show("Employee record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            reader.Close();
            con.Close();

            try
            {
                // Insert leave application into the database
                string query = "INSERT INTO Leave (EmployeeNumber, LeaveType, StartDate, EndDate, Status) VALUES (@EmployeeNumber, @LeaveType, @StartDate, @EndDate, 'Pending')";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);
                cmd.Parameters.AddWithValue("@LeaveType", leaveType);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Leave application submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

                else
                {
                    MessageBox.Show("Failed to submit leave application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Deduct the leave from the appropriate balance
                string updateBalanceQuery = string.Empty;

                if (leaveType == "Annual")
                    updateBalanceQuery = "UPDATE Employee SET AnnualLeaves = AnnualLeaves - @TotalDays WHERE EmployeeNumber = @EmployeeNumber";
                else if (leaveType == "Casual")
                    updateBalanceQuery = "UPDATE Employee SET CasualLeaves = CasualLeaves - @TotalDays WHERE EmployeeNumber = @EmployeeNumber";
                else if (leaveType == "Short")
                    updateBalanceQuery = "UPDATE Employee SET ShortLeaves = ShortLeaves - 1 WHERE EmployeeNumber = @EmployeeNumber";

                if (!string.IsNullOrEmpty(updateBalanceQuery))
                {
                    SqlCommand updateCmd = new SqlCommand(updateBalanceQuery, con);
                    updateCmd.Parameters.AddWithValue("@TotalDays", (endDate - startDate).Days + 1);
                    updateCmd.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);

                    con.Open();
                    updateCmd.ExecuteNonQuery();
                    con.Close();
                }

            }

             catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                MessageBox.Show($"An error occurred while processing the leave application.\n\nDetails: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeNumber.Clear();
            cmbLeaveType.ResetText();
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Page obj = new Employee_Page(LoggedInEmployeeNumber);
            obj.Show();
        }
    }
}
