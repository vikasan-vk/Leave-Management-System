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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\E137138_Programming\E137138_Programming\Grifindo.mdf;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                // Get the user input
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                try
                {
                    if (rbAdmin.Checked) // Check if Admin RadioButton is selected
                    {
                        con.Open(); // Open the connection

                        // Use parameterized query for Admin login
                        string query_Login = "SELECT COUNT(1) FROM Admin WHERE username = @Username AND password = @Password";
                        SqlCommand cmd = new SqlCommand(query_Login, con);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1)
                        {
                            MessageBox.Show("Admin Login Success!","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide(); // Hide the login form
                            Admin_Page admin = new Admin_Page(); // Navigate to Admin page
                            admin.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Admin credentials. Please check Username and Password and try again.",
                                            "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else if (rbEmployee.Checked) // Check if Employee RadioButton is selected
                {
                    con.Open(); // Open the connection

                    // Use parameterized query for Employee login
                    string query_Login = "SELECT EmployeeNumber FROM EmployeeLogin WHERE EmployeeNumber = @EmployeeNumber AND password = @Password";
                    SqlCommand cmd = new SqlCommand(query_Login, con);
                    cmd.Parameters.AddWithValue("@EmployeeNumber", username); // Employee_Number is used as username
                    cmd.Parameters.AddWithValue("@Password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string loggedInEmployeeNumber = result.ToString(); // Retrieve the Employee Number

                        MessageBox.Show("Employee Login Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide(); // Hide the login form

                        // Pass the EmployeeNumber to Employee_Page
                        Employee_Page employee = new Employee_Page(loggedInEmployeeNumber);
                        employee.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Employee credentials. Please check Employee Number and Password and try again.",
                                        "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close(); // Always close the connection
                }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            rbAdmin.Checked = false;
            rbEmployee.Checked = false;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

