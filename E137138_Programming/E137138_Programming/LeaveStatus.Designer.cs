namespace E137138_Programming
{
    partial class LeaveStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveStatus));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLeaveStatus = new System.Windows.Forms.DataGridView();
            this.btnDeleteLeave = new System.Windows.Forms.Button();
            this.btnBackToDashboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(328, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leave Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLeaveStatus
            // 
            this.dgvLeaveStatus.AllowUserToAddRows = false;
            this.dgvLeaveStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvLeaveStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaveStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaveStatus.GridColor = System.Drawing.Color.Tan;
            this.dgvLeaveStatus.Location = new System.Drawing.Point(119, 133);
            this.dgvLeaveStatus.Name = "dgvLeaveStatus";
            this.dgvLeaveStatus.ReadOnly = true;
            this.dgvLeaveStatus.Size = new System.Drawing.Size(568, 190);
            this.dgvLeaveStatus.TabIndex = 2;
            // 
            // btnDeleteLeave
            // 
            this.btnDeleteLeave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteLeave.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteLeave.Location = new System.Drawing.Point(578, 352);
            this.btnDeleteLeave.Name = "btnDeleteLeave";
            this.btnDeleteLeave.Size = new System.Drawing.Size(109, 23);
            this.btnDeleteLeave.TabIndex = 3;
            this.btnDeleteLeave.Text = "Cancel the Leave";
            this.btnDeleteLeave.UseVisualStyleBackColor = false;
            this.btnDeleteLeave.Click += new System.EventHandler(this.btnDeleteLeave_Click);
            // 
            // btnBackToDashboard
            // 
            this.btnBackToDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackToDashboard.BackColor = System.Drawing.Color.Teal;
            this.btnBackToDashboard.Location = new System.Drawing.Point(396, 352);
            this.btnBackToDashboard.Name = "btnBackToDashboard";
            this.btnBackToDashboard.Size = new System.Drawing.Size(75, 23);
            this.btnBackToDashboard.TabIndex = 4;
            this.btnBackToDashboard.Text = "Back";
            this.btnBackToDashboard.UseVisualStyleBackColor = false;
            this.btnBackToDashboard.Click += new System.EventHandler(this.btnBackToDashboard_Click);
            // 
            // LeaveStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackToDashboard);
            this.Controls.Add(this.btnDeleteLeave);
            this.Controls.Add(this.dgvLeaveStatus);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LeaveStatus";
            this.Text = "Leave Status";
            this.Load += new System.EventHandler(this.LeaveStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLeaveStatus;
        private System.Windows.Forms.Button btnDeleteLeave;
        private System.Windows.Forms.Button btnBackToDashboard;
    }
}