namespace EmployeeDB
{
    partial class AttendenceSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendenceSystem));
            this.button1 = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnCheckServices = new System.Windows.Forms.Button();
            this.btnShortAttendence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(353, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Employee";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(1, 1);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(112, 42);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(751, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 44);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(119, 1);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(248, 42);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.Text = "Check Attendence of Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnCheckServices
            // 
            this.btnCheckServices.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnCheckServices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheckServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCheckServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckServices.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckServices.Location = new System.Drawing.Point(373, 1);
            this.btnCheckServices.Name = "btnCheckServices";
            this.btnCheckServices.Size = new System.Drawing.Size(123, 42);
            this.btnCheckServices.TabIndex = 8;
            this.btnCheckServices.Text = "Check Service";
            this.btnCheckServices.UseVisualStyleBackColor = true;
            this.btnCheckServices.Click += new System.EventHandler(this.btnCheckServices_Click);
            // 
            // btnShortAttendence
            // 
            this.btnShortAttendence.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnShortAttendence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShortAttendence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnShortAttendence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShortAttendence.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShortAttendence.Location = new System.Drawing.Point(511, 1);
            this.btnShortAttendence.Name = "btnShortAttendence";
            this.btnShortAttendence.Size = new System.Drawing.Size(234, 42);
            this.btnShortAttendence.TabIndex = 9;
            this.btnShortAttendence.Text = "Short Attendence Employee";
            this.btnShortAttendence.UseVisualStyleBackColor = true;
            this.btnShortAttendence.Click += new System.EventHandler(this.btnShortAttendence_Click);
            // 
            // AttendenceSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 504);
            this.Controls.Add(this.btnShortAttendence);
            this.Controls.Add(this.btnCheckServices);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AttendenceSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage EMployees";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AttendenceSystem_FormClosed);
            this.Load += new System.EventHandler(this.AttendenceSystem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnCheckServices;
        private System.Windows.Forms.Button btnShortAttendence;
    }
}

