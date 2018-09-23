namespace EmployeeDB
{
    partial class MarkAttendence
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
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgvAttendenceRecord = new System.Windows.Forms.DataGridView();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblMessege = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendenceRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(57, 50);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(85, 20);
            this.lblEmployeeId.TabIndex = 3;
            this.lblEmployeeId.Text = "Employee Id";
            this.lblEmployeeId.Click += new System.EventHandler(this.lblEmployeeId_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(218, 48);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(206, 25);
            this.txtId.TabIndex = 2;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // dgvAttendenceRecord
            // 
            this.dgvAttendenceRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendenceRecord.Location = new System.Drawing.Point(43, 189);
            this.dgvAttendenceRecord.Name = "dgvAttendenceRecord";
            this.dgvAttendenceRecord.Size = new System.Drawing.Size(429, 150);
            this.dgvAttendenceRecord.TabIndex = 6;
            // 
            // btnSignIn
            // 
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(119, 115);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(120, 35);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "Login";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(304, 115);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(120, 35);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblMessege
            // 
            this.lblMessege.AutoSize = true;
            this.lblMessege.ForeColor = System.Drawing.Color.Red;
            this.lblMessege.Location = new System.Drawing.Point(215, 87);
            this.lblMessege.Name = "lblMessege";
            this.lblMessege.Size = new System.Drawing.Size(0, 13);
            this.lblMessege.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Attendence Record:";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(421, 360);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 33);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MarkAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 405);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessege);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.dgvAttendenceRecord);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.txtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MarkAttendence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mark Attendence";
            this.Load += new System.EventHandler(this.MarkAttendence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendenceRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgvAttendenceRecord;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblMessege;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}