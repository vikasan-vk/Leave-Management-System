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
    public partial class Admin_Page : Form
    {
        public Admin_Page()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaveManagement obj = new LeaveManagement();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login obj = new Login();
            obj.Show();
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

        private void Admin_Page_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployeeRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewEmployeeRegistration obj = new NewEmployeeRegistration();
            obj.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaveReportAdmin obj = new LeaveReportAdmin();
            obj.Show();
        }
    }
}
