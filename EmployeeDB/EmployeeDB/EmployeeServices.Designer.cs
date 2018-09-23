namespace EmployeeDB
{
    partial class EmployeeServices
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
            this.btnCheckServices = new System.Windows.Forms.Button();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblMessege = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckServices
            // 
            this.btnCheckServices.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnCheckServices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheckServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCheckServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckServices.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckServices.Location = new System.Drawing.Point(493, 150);
            this.btnCheckServices.Name = "btnCheckServices";
            this.btnCheckServices.Size = new System.Drawing.Size(123, 40);
            this.btnCheckServices.TabIndex = 7;
            this.btnCheckServices.Text = "Check Service";
            this.btnCheckServices.UseVisualStyleBackColor = true;
            this.btnCheckServices.Click += new System.EventHandler(this.btnCheckServices_Click);
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(252, 98);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(85, 20);
            this.lblEmployeeId.TabIndex = 6;
            this.lblEmployeeId.Text = "Employee Id";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(410, 93);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(206, 25);
            this.txtId.TabIndex = 5;
            // 
            // lblMessege
            // 
            this.lblMessege.AutoSize = true;
            this.lblMessege.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessege.Location = new System.Drawing.Point(252, 222);
            this.lblMessege.Name = "lblMessege";
            this.lblMessege.Size = new System.Drawing.Size(0, 20);
            this.lblMessege.TabIndex = 6;
            // 
            // EmployeeServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCheckServices);
            this.Controls.Add(this.lblMessege);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.txtId);
            this.Location = new System.Drawing.Point(0, 50);
            this.Name = "EmployeeServices";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(899, 473);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckServices;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblMessege;
    }
}
