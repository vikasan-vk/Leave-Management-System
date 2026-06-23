namespace E137138_Programming
{
    partial class LeaveManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveManagement));
            this.tabContLeaveManagement = new System.Windows.Forms.TabControl();
            this.tbPageLeaveAllocation = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtShortLeaves = new System.Windows.Forms.TextBox();
            this.txtCasualLeaves = new System.Windows.Forms.TextBox();
            this.txtAnnualLeaves = new System.Windows.Forms.TextBox();
            this.cmbEmployeeType = new System.Windows.Forms.ComboBox();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.lbShortLeaves = new System.Windows.Forms.Label();
            this.lbCasualLeaves = new System.Windows.Forms.Label();
            this.lbAnnualLeaves = new System.Windows.Forms.Label();
            this.lbEmployeeType = new System.Windows.Forms.Label();
            this.lbEmployeeNumber = new System.Windows.Forms.Label();
            this.tbPageRoasterTiming = new System.Windows.Forms.TabPage();
            this.btnUpdateRoaster = new System.Windows.Forms.Button();
            this.btnLoadRoaster = new System.Windows.Forms.Button();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.txtRoasterEmloyeeNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPageLeaveApproval = new System.Windows.Forms.TabPage();
            this.gbxLeaveDetails = new System.Windows.Forms.GroupBox();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtLeaveType = new System.Windows.Forms.TextBox();
            this.txtEmployeeNumber1 = new System.Windows.Forms.TextBox();
            this.txtLeaveID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPendingLeaves = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabContLeaveManagement.SuspendLayout();
            this.tbPageLeaveAllocation.SuspendLayout();
            this.tbPageRoasterTiming.SuspendLayout();
            this.tbPageLeaveApproval.SuspendLayout();
            this.gbxLeaveDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingLeaves)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContLeaveManagement
            // 
            this.tabContLeaveManagement.Controls.Add(this.tbPageLeaveAllocation);
            this.tabContLeaveManagement.Controls.Add(this.tbPageRoasterTiming);
            this.tabContLeaveManagement.Controls.Add(this.tbPageLeaveApproval);
            this.tabContLeaveManagement.Location = new System.Drawing.Point(94, 25);
            this.tabContLeaveManagement.Multiline = true;
            this.tabContLeaveManagement.Name = "tabContLeaveManagement";
            this.tabContLeaveManagement.SelectedIndex = 0;
            this.tabContLeaveManagement.Size = new System.Drawing.Size(659, 366);
            this.tabContLeaveManagement.TabIndex = 0;
            // 
            // tbPageLeaveAllocation
            // 
            this.tbPageLeaveAllocation.Controls.Add(this.btnUpdate);
            this.tbPageLeaveAllocation.Controls.Add(this.btnLoad);
            this.tbPageLeaveAllocation.Controls.Add(this.txtShortLeaves);
            this.tbPageLeaveAllocation.Controls.Add(this.txtCasualLeaves);
            this.tbPageLeaveAllocation.Controls.Add(this.txtAnnualLeaves);
            this.tbPageLeaveAllocation.Controls.Add(this.cmbEmployeeType);
            this.tbPageLeaveAllocation.Controls.Add(this.txtEmployeeNumber);
            this.tbPageLeaveAllocation.Controls.Add(this.lbShortLeaves);
            this.tbPageLeaveAllocation.Controls.Add(this.lbCasualLeaves);
            this.tbPageLeaveAllocation.Controls.Add(this.lbAnnualLeaves);
            this.tbPageLeaveAllocation.Controls.Add(this.lbEmployeeType);
            this.tbPageLeaveAllocation.Controls.Add(this.lbEmployeeNumber);
            this.tbPageLeaveAllocation.Location = new System.Drawing.Point(4, 22);
            this.tbPageLeaveAllocation.Name = "tbPageLeaveAllocation";
            this.tbPageLeaveAllocation.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageLeaveAllocation.Size = new System.Drawing.Size(651, 326);
            this.tbPageLeaveAllocation.TabIndex = 0;
            this.tbPageLeaveAllocation.Text = "Leave Allocation";
            this.tbPageLeaveAllocation.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(315, 236);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(315, 32);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtShortLeaves
            // 
            this.txtShortLeaves.Location = new System.Drawing.Point(209, 198);
            this.txtShortLeaves.Name = "txtShortLeaves";
            this.txtShortLeaves.Size = new System.Drawing.Size(100, 20);
            this.txtShortLeaves.TabIndex = 9;
            // 
            // txtCasualLeaves
            // 
            this.txtCasualLeaves.Location = new System.Drawing.Point(209, 155);
            this.txtCasualLeaves.Name = "txtCasualLeaves";
            this.txtCasualLeaves.Size = new System.Drawing.Size(100, 20);
            this.txtCasualLeaves.TabIndex = 8;
            // 
            // txtAnnualLeaves
            // 
            this.txtAnnualLeaves.Location = new System.Drawing.Point(209, 114);
            this.txtAnnualLeaves.Name = "txtAnnualLeaves";
            this.txtAnnualLeaves.Size = new System.Drawing.Size(100, 20);
            this.txtAnnualLeaves.TabIndex = 7;
            // 
            // cmbEmployeeType
            // 
            this.cmbEmployeeType.FormattingEnabled = true;
            this.cmbEmployeeType.Items.AddRange(new object[] {
            "Permanent Employee",
            "Newly Joined Employee"});
            this.cmbEmployeeType.Location = new System.Drawing.Point(209, 73);
            this.cmbEmployeeType.Name = "cmbEmployeeType";
            this.cmbEmployeeType.Size = new System.Drawing.Size(121, 21);
            this.cmbEmployeeType.TabIndex = 6;
            this.cmbEmployeeType.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeType_SelectedIndexChanged);
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(209, 34);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeNumber.TabIndex = 5;
            // 
            // lbShortLeaves
            // 
            this.lbShortLeaves.AutoSize = true;
            this.lbShortLeaves.Location = new System.Drawing.Point(59, 201);
            this.lbShortLeaves.Name = "lbShortLeaves";
            this.lbShortLeaves.Size = new System.Drawing.Size(70, 13);
            this.lbShortLeaves.TabIndex = 4;
            this.lbShortLeaves.Text = "Short Leaves";
            // 
            // lbCasualLeaves
            // 
            this.lbCasualLeaves.AutoSize = true;
            this.lbCasualLeaves.Location = new System.Drawing.Point(59, 158);
            this.lbCasualLeaves.Name = "lbCasualLeaves";
            this.lbCasualLeaves.Size = new System.Drawing.Size(77, 13);
            this.lbCasualLeaves.TabIndex = 3;
            this.lbCasualLeaves.Text = "Casual Leaves";
            // 
            // lbAnnualLeaves
            // 
            this.lbAnnualLeaves.AutoSize = true;
            this.lbAnnualLeaves.Location = new System.Drawing.Point(59, 117);
            this.lbAnnualLeaves.Name = "lbAnnualLeaves";
            this.lbAnnualLeaves.Size = new System.Drawing.Size(78, 13);
            this.lbAnnualLeaves.TabIndex = 2;
            this.lbAnnualLeaves.Text = "Annual Leaves";
            this.lbAnnualLeaves.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbEmployeeType
            // 
            this.lbEmployeeType.AutoSize = true;
            this.lbEmployeeType.Location = new System.Drawing.Point(59, 76);
            this.lbEmployeeType.Name = "lbEmployeeType";
            this.lbEmployeeType.Size = new System.Drawing.Size(80, 13);
            this.lbEmployeeType.TabIndex = 1;
            this.lbEmployeeType.Text = "Employee Type";
            // 
            // lbEmployeeNumber
            // 
            this.lbEmployeeNumber.AutoSize = true;
            this.lbEmployeeNumber.Location = new System.Drawing.Point(59, 37);
            this.lbEmployeeNumber.Name = "lbEmployeeNumber";
            this.lbEmployeeNumber.Size = new System.Drawing.Size(93, 13);
            this.lbEmployeeNumber.TabIndex = 0;
            this.lbEmployeeNumber.Text = "Employee Number";
            // 
            // tbPageRoasterTiming
            // 
            this.tbPageRoasterTiming.Controls.Add(this.btnUpdateRoaster);
            this.tbPageRoasterTiming.Controls.Add(this.btnLoadRoaster);
            this.tbPageRoasterTiming.Controls.Add(this.dtpEndTime);
            this.tbPageRoasterTiming.Controls.Add(this.dtpStartTime);
            this.tbPageRoasterTiming.Controls.Add(this.txtRoasterEmloyeeNumber);
            this.tbPageRoasterTiming.Controls.Add(this.label3);
            this.tbPageRoasterTiming.Controls.Add(this.label2);
            this.tbPageRoasterTiming.Controls.Add(this.label1);
            this.tbPageRoasterTiming.Location = new System.Drawing.Point(4, 22);
            this.tbPageRoasterTiming.Name = "tbPageRoasterTiming";
            this.tbPageRoasterTiming.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageRoasterTiming.Size = new System.Drawing.Size(651, 326);
            this.tbPageRoasterTiming.TabIndex = 1;
            this.tbPageRoasterTiming.Text = "Roaster Timing";
            this.tbPageRoasterTiming.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRoaster
            // 
            this.btnUpdateRoaster.Location = new System.Drawing.Point(237, 236);
            this.btnUpdateRoaster.Name = "btnUpdateRoaster";
            this.btnUpdateRoaster.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateRoaster.TabIndex = 6;
            this.btnUpdateRoaster.Text = "Update";
            this.btnUpdateRoaster.UseVisualStyleBackColor = true;
            this.btnUpdateRoaster.Click += new System.EventHandler(this.btnUpdateRoaster_Click);
            // 
            // btnLoadRoaster
            // 
            this.btnLoadRoaster.Location = new System.Drawing.Point(362, 26);
            this.btnLoadRoaster.Name = "btnLoadRoaster";
            this.btnLoadRoaster.Size = new System.Drawing.Size(75, 20);
            this.btnLoadRoaster.TabIndex = 5;
            this.btnLoadRoaster.Text = "Load";
            this.btnLoadRoaster.UseVisualStyleBackColor = true;
            this.btnLoadRoaster.Click += new System.EventHandler(this.btnLoadRoaster_Click);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(237, 110);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(128, 20);
            this.dtpEndTime.TabIndex = 4;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(237, 69);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(128, 20);
            this.dtpStartTime.TabIndex = 0;
            // 
            // txtRoasterEmloyeeNumber
            // 
            this.txtRoasterEmloyeeNumber.Location = new System.Drawing.Point(237, 26);
            this.txtRoasterEmloyeeNumber.Name = "txtRoasterEmloyeeNumber";
            this.txtRoasterEmloyeeNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRoasterEmloyeeNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Number";
            // 
            // tbPageLeaveApproval
            // 
            this.tbPageLeaveApproval.Controls.Add(this.gbxLeaveDetails);
            this.tbPageLeaveApproval.Controls.Add(this.dgvPendingLeaves);
            this.tbPageLeaveApproval.Location = new System.Drawing.Point(4, 22);
            this.tbPageLeaveApproval.Name = "tbPageLeaveApproval";
            this.tbPageLeaveApproval.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageLeaveApproval.Size = new System.Drawing.Size(651, 340);
            this.tbPageLeaveApproval.TabIndex = 2;
            this.tbPageLeaveApproval.Text = "Leave Approval";
            this.tbPageLeaveApproval.UseVisualStyleBackColor = true;
            this.tbPageLeaveApproval.Click += new System.EventHandler(this.tbPageLeaveApproval_Click);
            // 
            // gbxLeaveDetails
            // 
            this.gbxLeaveDetails.Controls.Add(this.btnReject);
            this.gbxLeaveDetails.Controls.Add(this.btnApprove);
            this.gbxLeaveDetails.Controls.Add(this.txtStatus);
            this.gbxLeaveDetails.Controls.Add(this.txtEndDate);
            this.gbxLeaveDetails.Controls.Add(this.txtStartDate);
            this.gbxLeaveDetails.Controls.Add(this.txtLeaveType);
            this.gbxLeaveDetails.Controls.Add(this.txtEmployeeNumber1);
            this.gbxLeaveDetails.Controls.Add(this.txtLeaveID);
            this.gbxLeaveDetails.Controls.Add(this.label9);
            this.gbxLeaveDetails.Controls.Add(this.label8);
            this.gbxLeaveDetails.Controls.Add(this.label7);
            this.gbxLeaveDetails.Controls.Add(this.label6);
            this.gbxLeaveDetails.Controls.Add(this.label5);
            this.gbxLeaveDetails.Controls.Add(this.label4);
            this.gbxLeaveDetails.Location = new System.Drawing.Point(45, 150);
            this.gbxLeaveDetails.Name = "gbxLeaveDetails";
            this.gbxLeaveDetails.Size = new System.Drawing.Size(556, 183);
            this.gbxLeaveDetails.TabIndex = 1;
            this.gbxLeaveDetails.TabStop = false;
            this.gbxLeaveDetails.Text = "Leave Details";
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(450, 96);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(75, 23);
            this.btnReject.TabIndex = 13;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(450, 56);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 12;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(296, 117);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 11;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(296, 75);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(100, 20);
            this.txtEndDate.TabIndex = 10;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(296, 38);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(100, 20);
            this.txtStartDate.TabIndex = 9;
            // 
            // txtLeaveType
            // 
            this.txtLeaveType.Location = new System.Drawing.Point(105, 117);
            this.txtLeaveType.Name = "txtLeaveType";
            this.txtLeaveType.ReadOnly = true;
            this.txtLeaveType.Size = new System.Drawing.Size(100, 20);
            this.txtLeaveType.TabIndex = 8;
            // 
            // txtEmployeeNumber1
            // 
            this.txtEmployeeNumber1.Location = new System.Drawing.Point(105, 75);
            this.txtEmployeeNumber1.Name = "txtEmployeeNumber1";
            this.txtEmployeeNumber1.ReadOnly = true;
            this.txtEmployeeNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeNumber1.TabIndex = 7;
            // 
            // txtLeaveID
            // 
            this.txtLeaveID.Location = new System.Drawing.Point(105, 38);
            this.txtLeaveID.Name = "txtLeaveID";
            this.txtLeaveID.ReadOnly = true;
            this.txtLeaveID.Size = new System.Drawing.Size(100, 20);
            this.txtLeaveID.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "End Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Leave Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Employee Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Leave ID";
            // 
            // dgvPendingLeaves
            // 
            this.dgvPendingLeaves.AllowUserToAddRows = false;
            this.dgvPendingLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingLeaves.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPendingLeaves.Location = new System.Drawing.Point(3, 3);
            this.dgvPendingLeaves.Name = "dgvPendingLeaves";
            this.dgvPendingLeaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendingLeaves.Size = new System.Drawing.Size(645, 141);
            this.dgvPendingLeaves.TabIndex = 0;
            this.dgvPendingLeaves.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPendingLeaves_CellClick);
            this.dgvPendingLeaves.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPendingLeaves_CellContentClick_1);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(94, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LeaveManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabContLeaveManagement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LeaveManagement";
            this.Text = "Leave Management";
            this.Load += new System.EventHandler(this.LeaveManagement_Load);
            this.tabContLeaveManagement.ResumeLayout(false);
            this.tbPageLeaveAllocation.ResumeLayout(false);
            this.tbPageLeaveAllocation.PerformLayout();
            this.tbPageRoasterTiming.ResumeLayout(false);
            this.tbPageRoasterTiming.PerformLayout();
            this.tbPageLeaveApproval.ResumeLayout(false);
            this.gbxLeaveDetails.ResumeLayout(false);
            this.gbxLeaveDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingLeaves)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContLeaveManagement;
        private System.Windows.Forms.TabPage tbPageLeaveAllocation;
        private System.Windows.Forms.TabPage tbPageRoasterTiming;
        private System.Windows.Forms.TabPage tbPageLeaveApproval;
        private System.Windows.Forms.ComboBox cmbEmployeeType;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.Label lbShortLeaves;
        private System.Windows.Forms.Label lbCasualLeaves;
        private System.Windows.Forms.Label lbAnnualLeaves;
        private System.Windows.Forms.Label lbEmployeeType;
        private System.Windows.Forms.Label lbEmployeeNumber;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtShortLeaves;
        private System.Windows.Forms.TextBox txtCasualLeaves;
        private System.Windows.Forms.TextBox txtAnnualLeaves;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdateRoaster;
        private System.Windows.Forms.Button btnLoadRoaster;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.TextBox txtRoasterEmloyeeNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxLeaveDetails;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtLeaveType;
        private System.Windows.Forms.TextBox txtEmployeeNumber1;
        private System.Windows.Forms.TextBox txtLeaveID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPendingLeaves;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnApprove;
    }
}