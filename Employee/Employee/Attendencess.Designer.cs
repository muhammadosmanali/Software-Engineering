namespace Employee
{
    partial class Attendencess
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblmessege = new System.Windows.Forms.Label();
            this.dgvAttendence = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.EmployeeId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendence)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmessege
            // 
            this.lblmessege.AutoSize = true;
            this.lblmessege.ForeColor = System.Drawing.Color.Red;
            this.lblmessege.Location = new System.Drawing.Point(584, 159);
            this.lblmessege.Name = "lblmessege";
            this.lblmessege.Size = new System.Drawing.Size(0, 13);
            this.lblmessege.TabIndex = 11;
            // 
            // dgvAttendence
            // 
            this.dgvAttendence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendence.Location = new System.Drawing.Point(200, 228);
            this.dgvAttendence.Name = "dgvAttendence";
            this.dgvAttendence.Size = new System.Drawing.Size(440, 220);
            this.dgvAttendence.TabIndex = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(442, 154);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(237, 154);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 9;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(336, 101);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(181, 20);
            this.txtEmployeeId.TabIndex = 7;
            this.txtEmployeeId.TextChanged += new System.EventHandler(this.txtEmployeeId_TextChanged);
            // 
            // EmployeeId
            // 
            this.EmployeeId.AutoSize = true;
            this.EmployeeId.Location = new System.Drawing.Point(223, 104);
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Size = new System.Drawing.Size(18, 13);
            this.EmployeeId.TabIndex = 6;
            this.EmployeeId.Text = "ID";
            // 
            // Attendencess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblmessege);
            this.Controls.Add(this.dgvAttendence);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.EmployeeId);
            this.Location = new System.Drawing.Point(0, 30);
            this.Name = "Attendencess";
            this.Size = new System.Drawing.Size(832, 537);
            this.Load += new System.EventHandler(this.Attendencess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmessege;
        private System.Windows.Forms.DataGridView dgvAttendence;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label EmployeeId;
    }
}
