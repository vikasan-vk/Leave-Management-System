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
    public partial class ViewLeaveReports : Form
    {
        private string LoggedInEmployeeNumber;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\E137138_Programming\E137138_Programming\Grifindo.mdf;Integrated Security=True");

        public ViewLeaveReports(string EmployeeNumber)
        {
            InitializeComponent();
            LoggedInEmployeeNumber = EmployeeNumber;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Page obj = new Employee_Page(LoggedInEmployeeNumber);
            obj.Show();

        }

        private void ViewLeaveReports_Load(object sender, EventArgs e)
        {
            // Example Employee Number - Replace this with the logged-in employee's ID
            string EmployeeNumber = LoggedInEmployeeNumber;

            // Load data
            LoadLeaveHistory(EmployeeNumber);
            LoadLeaveBalance(EmployeeNumber);
            
        }

        private void LoadLeaveHistory(string EmployeeNumber)
        {
            try
            {
                string query = "SELECT LeaveType, StartDate, EndDate, Status FROM Leave WHERE EmployeeNumber = @EmployeeNumber";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvLeaveHistory.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading leave history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load Remaining Leave Balance
        private void LoadLeaveBalance(string EmployeeNumber)
        {
            try
            {
                string query = "SELECT AnnualLeaves, CasualLeaves, ShortLeaves FROM Employee WHERE EmployeeNumber = @EmployeeNumber";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtAnnualLeaves.Text = reader["AnnualLeaves"].ToString();
                    txtCasualLeaves.Text = reader["CasualLeaves"].ToString();
                    txtShortLeaves.Text = reader["ShortLeaves"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading leave balance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
    }
}
