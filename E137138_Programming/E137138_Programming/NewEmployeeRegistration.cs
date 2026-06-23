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
    public partial class NewEmployeeRegistration : Form
    {
        public NewEmployeeRegistration()
        {
            InitializeComponent();
        }

        private string GenerateEmployeeNumber()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\E137138_Programming\E137138_Programming\Grifindo.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MAX(EmployeeNumber) FROM Employee";
                SqlCommand cmd = new SqlCommand(query, conn);

                object result = cmd.ExecuteScalar();

                if (result == DBNull.Value || result == null)
                {
                    return "E001";
                }

                string lastEmployeeNumber = result.ToString();
                int numericPart = int.Parse(lastEmployeeNumber.Substring(1)) + 1;

                return "E" + numericPart.ToString("D3");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewEmployeeRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Generate EmployeeNumber
            string EmployeeNumber = GenerateEmployeeNumber();

            // Collect employee details
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string Email = txtEmail.Text;
            string Phone = txtPhone.Text;
            string Address = txtAddress.Text;
            string Position = txtPositon.Text;
            string EmployeeType = cmbEmployeeType.SelectedItem.ToString();
            string Password = txtPassword.Text;

            if (string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Position))
            {
                MessageBox.Show("Please fill all the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\E137138_Programming\E137138_Programming\Grifindo.mdf;Integrated Security=True";

            // SQL Queries
            string insertEmployeeQuery = "INSERT INTO Employee (EmployeeNumber, FirstName, LastName, Email, Phone, Address, Position, EmployeeType) " +
                                         "VALUES (@EmployeeNumber, @FirstName, @LastName, @Email, @Phone, @Address, @Position, @EmployeeType)";

            string insertEmployeeLoginQuery = "INSERT INTO EmployeeLogin (EmployeeNumber, Password) " +
                                              "VALUES (@EmployeeNumber, @Password)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Insert into Employee table
                    using (SqlCommand cmd = new SqlCommand(insertEmployeeQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber);
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@Phone", Phone);
                        cmd.Parameters.AddWithValue("@Address", Address);
                        cmd.Parameters.AddWithValue("@Position", Position);
                        cmd.Parameters.AddWithValue("@EmployeeType", EmployeeType);
                        cmd.ExecuteNonQuery();
                    }

                    // Insert into EmployeeLogin table
                    using (SqlCommand cmd = new SqlCommand(insertEmployeeLoginQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Employee registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you Sure?, Do You Want to Exit ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (confirmation == DialogResult.No)
            {
                //nothing will happen
            }
            else
            {
                //nothing will happen
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            {
                txtFirstName.Clear();
                txtLastName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtAddress.Clear();
                txtPositon.Clear();
                cmbEmployeeType.ResetText();
                txtPassword.Clear();
            }
        }

        private void grpbxEmployeeRegistration_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Page obj = new Admin_Page();
            obj.Show();
        }

        private void cmbEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
