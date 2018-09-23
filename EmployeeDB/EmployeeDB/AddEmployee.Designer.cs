namespace EmployeeDB
{
    partial class AddEmployee
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCnic = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMailingAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblCnic = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblMailingAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.lblCnicMessege = new System.Windows.Forms.Label();
            this.lblEmpIdMessege = new System.Windows.Forms.Label();
            this.lblNameMessege = new System.Windows.Forms.Label();
            this.lblSalaryMessege = new System.Windows.Forms.Label();
            this.lblEmailMessege = new System.Windows.Forms.Label();
            this.lblAddressMessege = new System.Windows.Forms.Label();
            this.lblMessege = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmployeeAdded = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(367, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 25);
            this.txtName.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(367, 50);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(206, 25);
            this.txtId.TabIndex = 0;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtCnic
            // 
            this.txtCnic.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnic.Location = new System.Drawing.Point(367, 81);
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(206, 25);
            this.txtCnic.TabIndex = 0;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(367, 143);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(206, 25);
            this.txtSalary.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(367, 174);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 25);
            this.txtEmail.TabIndex = 0;
            // 
            // txtMailingAddress
            // 
            this.txtMailingAddress.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMailingAddress.Location = new System.Drawing.Point(367, 205);
            this.txtMailingAddress.Name = "txtMailingAddress";
            this.txtMailingAddress.Size = new System.Drawing.Size(206, 25);
            this.txtMailingAddress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(209, 55);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(85, 20);
            this.lblEmployeeId.TabIndex = 1;
            this.lblEmployeeId.Text = "Employee Id";
            // 
            // lblCnic
            // 
            this.lblCnic.AutoSize = true;
            this.lblCnic.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnic.Location = new System.Drawing.Point(209, 86);
            this.lblCnic.Name = "lblCnic";
            this.lblCnic.Size = new System.Drawing.Size(45, 20);
            this.lblCnic.TabIndex = 1;
            this.lblCnic.Text = "CNIC";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDate.Location = new System.Drawing.Point(209, 117);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(123, 20);
            this.lblAppointmentDate.TabIndex = 1;
            this.lblAppointmentDate.Text = "Appointment Date";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(209, 148);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(44, 20);
            this.lblSalary.TabIndex = 1;
            this.lblSalary.Text = "Salary";
            // 
            // lblMailingAddress
            // 
            this.lblMailingAddress.AutoSize = true;
            this.lblMailingAddress.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailingAddress.Location = new System.Drawing.Point(209, 207);
            this.lblMailingAddress.Name = "lblMailingAddress";
            this.lblMailingAddress.Size = new System.Drawing.Size(107, 20);
            this.lblMailingAddress.TabIndex = 1;
            this.lblMailingAddress.Text = "Mailing Address";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(209, 176);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(450, 236);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(123, 40);
            this.btnAddEmployee.TabIndex = 3;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentDate.Location = new System.Drawing.Point(367, 113);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(206, 25);
            this.dtpAppointmentDate.TabIndex = 4;
            // 
            // lblCnicMessege
            // 
            this.lblCnicMessege.AutoSize = true;
            this.lblCnicMessege.ForeColor = System.Drawing.Color.Red;
            this.lblCnicMessege.Location = new System.Drawing.Point(608, 87);
            this.lblCnicMessege.Name = "lblCnicMessege";
            this.lblCnicMessege.Size = new System.Drawing.Size(0, 13);
            this.lblCnicMessege.TabIndex = 5;
            // 
            // lblEmpIdMessege
            // 
            this.lblEmpIdMessege.AutoSize = true;
            this.lblEmpIdMessege.ForeColor = System.Drawing.Color.Red;
            this.lblEmpIdMessege.Location = new System.Drawing.Point(608, 56);
            this.lblEmpIdMessege.Name = "lblEmpIdMessege";
            this.lblEmpIdMessege.Size = new System.Drawing.Size(0, 13);
            this.lblEmpIdMessege.TabIndex = 5;
            // 
            // lblNameMessege
            // 
            this.lblNameMessege.AutoSize = true;
            this.lblNameMessege.ForeColor = System.Drawing.Color.Red;
            this.lblNameMessege.Location = new System.Drawing.Point(608, 25);
            this.lblNameMessege.Name = "lblNameMessege";
            this.lblNameMessege.Size = new System.Drawing.Size(0, 13);
            this.lblNameMessege.TabIndex = 5;
            // 
            // lblSalaryMessege
            // 
            this.lblSalaryMessege.AutoSize = true;
            this.lblSalaryMessege.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryMessege.Location = new System.Drawing.Point(608, 149);
            this.lblSalaryMessege.Name = "lblSalaryMessege";
            this.lblSalaryMessege.Size = new System.Drawing.Size(0, 13);
            this.lblSalaryMessege.TabIndex = 5;
            // 
            // lblEmailMessege
            // 
            this.lblEmailMessege.AutoSize = true;
            this.lblEmailMessege.ForeColor = System.Drawing.Color.Red;
            this.lblEmailMessege.Location = new System.Drawing.Point(608, 180);
            this.lblEmailMessege.Name = "lblEmailMessege";
            this.lblEmailMessege.Size = new System.Drawing.Size(0, 13);
            this.lblEmailMessege.TabIndex = 5;
            // 
            // lblAddressMessege
            // 
            this.lblAddressMessege.AutoSize = true;
            this.lblAddressMessege.ForeColor = System.Drawing.Color.Red;
            this.lblAddressMessege.Location = new System.Drawing.Point(608, 211);
            this.lblAddressMessege.Name = "lblAddressMessege";
            this.lblAddressMessege.Size = new System.Drawing.Size(0, 13);
            this.lblAddressMessege.TabIndex = 5;
            // 
            // lblMessege
            // 
            this.lblMessege.AutoSize = true;
            this.lblMessege.ForeColor = System.Drawing.Color.Red;
            this.lblMessege.Location = new System.Drawing.Point(213, 246);
            this.lblMessege.Name = "lblMessege";
            this.lblMessege.Size = new System.Drawing.Size(0, 13);
            this.lblMessege.TabIndex = 6;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(90, 315);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(742, 135);
            this.dgvEmployee.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee Record:";
            // 
            // lblEmployeeAdded
            // 
            this.lblEmployeeAdded.AutoSize = true;
            this.lblEmployeeAdded.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeAdded.Location = new System.Drawing.Point(607, 236);
            this.lblEmployeeAdded.Name = "lblEmployeeAdded";
            this.lblEmployeeAdded.Size = new System.Drawing.Size(0, 20);
            this.lblEmployeeAdded.TabIndex = 9;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEmployeeAdded);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.lblMessege);
            this.Controls.Add(this.lblNameMessege);
            this.Controls.Add(this.lblEmpIdMessege);
            this.Controls.Add(this.lblAddressMessege);
            this.Controls.Add(this.lblEmailMessege);
            this.Controls.Add(this.lblSalaryMessege);
            this.Controls.Add(this.lblCnicMessege);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.lblMailingAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblAppointmentDate);
            this.Controls.Add(this.lblCnic);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMailingAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtCnic);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Location = new System.Drawing.Point(0, 50);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(899, 473);
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCnic;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMailingAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblCnic;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblMailingAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label lblCnicMessege;
        private System.Windows.Forms.Label lblEmpIdMessege;
        private System.Windows.Forms.Label lblNameMessege;
        private System.Windows.Forms.Label lblSalaryMessege;
        private System.Windows.Forms.Label lblEmailMessege;
        private System.Windows.Forms.Label lblAddressMessege;
        private System.Windows.Forms.Label lblMessege;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmployeeAdded;
    }
}
