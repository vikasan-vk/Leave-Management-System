using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E137138_Programming
{
    public partial class Employee_Page : Form
    {
        private string LoggedInEmployeeNumber;

        public Employee_Page(string EmployeeNumber)
        {
            InitializeComponent();
            LoggedInEmployeeNumber = EmployeeNumber;
        }

        private void btnApplyLeave_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaveAplication obj = new LeaveAplication(LoggedInEmployeeNumber);
            obj.Show();
        }

        private void btnViewStatus_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaveStatus obj = new LeaveStatus(LoggedInEmployeeNumber);
            obj.Show();

        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewLeaveReports obj = new ViewLeaveReports(LoggedInEmployeeNumber);
            obj.Show();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure?, Do you want to Logout?","Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                this.Hide();
                Login obj = new Login();
                obj.Show();
            }
            else if (confirmation == DialogResult.No)
            { 
                // Nothing will happen
            }
            else
            {
                // Nothing will happen
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Employee_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
