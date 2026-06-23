namespace E137138_Programming
{
    partial class Admin_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Page));
            this.btnEmployeeRegister = new System.Windows.Forms.Button();
            this.btnLeaveManagement = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmployeeRegister
            // 
            this.btnEmployeeRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeRegister.Location = new System.Drawing.Point(47, 40);
            this.btnEmployeeRegister.Name = "btnEmployeeRegister";
            this.btnEmployeeRegister.Size = new System.Drawing.Size(190, 23);
            this.btnEmployeeRegister.TabIndex = 0;
            this.btnEmployeeRegister.Text = "Register New Employee";
            this.btnEmployeeRegister.UseVisualStyleBackColor = true;
            this.btnEmployeeRegister.Click += new System.EventHandler(this.btnEmployeeRegister_Click);
            // 
            // btnLeaveManagement
            // 
            this.btnLeaveManagement.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveManagement.Location = new System.Drawing.Point(47, 96);
            this.btnLeaveManagement.Name = "btnLeaveManagement";
            this.btnLeaveManagement.Size = new System.Drawing.Size(190, 23);
            this.btnLeaveManagement.TabIndex = 1;
            this.btnLeaveManagement.Text = "Leave Management";
            this.btnLeaveManagement.UseVisualStyleBackColor = true;
            this.btnLeaveManagement.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(47, 150);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(190, 23);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "View Leave Report";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(383, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back to Home Page";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Tan;
            this.lblAdmin.Location = new System.Drawing.Point(474, 73);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(180, 27);
            this.lblAdmin.TabIndex = 6;
            this.lblAdmin.Text = "Welcome Admin";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnLeaveManagement);
            this.groupBox1.Controls.Add(this.btnEmployeeRegister);
            this.groupBox1.Controls.Add(this.btnReports);
            this.groupBox1.Location = new System.Drawing.Point(432, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 206);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Admin_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Page";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.Admin_Page_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeRegister;
        private System.Windows.Forms.Button btnLeaveManagement;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}