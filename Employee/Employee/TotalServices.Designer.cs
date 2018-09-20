namespace Employee
{
    partial class TotalServices
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
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.EmployeeId = new System.Windows.Forms.Label();
            this.btnEmployeeService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmessege
            // 
            this.lblmessege.AutoSize = true;
            this.lblmessege.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessege.ForeColor = System.Drawing.Color.Black;
            this.lblmessege.Location = new System.Drawing.Point(228, 253);
            this.lblmessege.Name = "lblmessege";
            this.lblmessege.Size = new System.Drawing.Size(0, 15);
            this.lblmessege.TabIndex = 15;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(352, 130);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(181, 20);
            this.txtEmployeeId.TabIndex = 14;
            this.txtEmployeeId.TextChanged += new System.EventHandler(this.txtEmployeeId_TextChanged);
            // 
            // EmployeeId
            // 
            this.EmployeeId.AutoSize = true;
            this.EmployeeId.Location = new System.Drawing.Point(258, 133);
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Size = new System.Drawing.Size(18, 13);
            this.EmployeeId.TabIndex = 13;
            this.EmployeeId.Text = "ID";
            // 
            // btnEmployeeService
            // 
            this.btnEmployeeService.Location = new System.Drawing.Point(422, 182);
            this.btnEmployeeService.Name = "btnEmployeeService";
            this.btnEmployeeService.Size = new System.Drawing.Size(111, 23);
            this.btnEmployeeService.TabIndex = 16;
            this.btnEmployeeService.Text = "Employee Service";
            this.btnEmployeeService.UseVisualStyleBackColor = true;
            this.btnEmployeeService.Click += new System.EventHandler(this.btnEmployeeService_Click);
            // 
            // TotalServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEmployeeService);
            this.Controls.Add(this.lblmessege);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.EmployeeId);
            this.Location = new System.Drawing.Point(0, 30);
            this.Name = "TotalServices";
            this.Size = new System.Drawing.Size(832, 537);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmessege;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label EmployeeId;
        private System.Windows.Forms.Button btnEmployeeService;
    }
}
