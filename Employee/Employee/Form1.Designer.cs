namespace Employee
{
    partial class Form1
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
            this.llblAttendence = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.llblClose = new System.Windows.Forms.LinkLabel();
            this.llblEmployee = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // llblAttendence
            // 
            this.llblAttendence.AutoSize = true;
            this.llblAttendence.Location = new System.Drawing.Point(86, 9);
            this.llblAttendence.Name = "llblAttendence";
            this.llblAttendence.Size = new System.Drawing.Size(62, 13);
            this.llblAttendence.TabIndex = 5;
            this.llblAttendence.TabStop = true;
            this.llblAttendence.Text = "Attendence";
            this.llblAttendence.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblAttendence_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(370, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(161, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Employee with Short Attendence";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(178, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(162, 13);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Check Attendence of Employees";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // llblClose
            // 
            this.llblClose.AutoSize = true;
            this.llblClose.Location = new System.Drawing.Point(719, 9);
            this.llblClose.Name = "llblClose";
            this.llblClose.Size = new System.Drawing.Size(33, 13);
            this.llblClose.TabIndex = 9;
            this.llblClose.TabStop = true;
            this.llblClose.Text = "Close";
            this.llblClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblClose_LinkClicked);
            // 
            // llblEmployee
            // 
            this.llblEmployee.AutoSize = true;
            this.llblEmployee.Location = new System.Drawing.Point(13, 9);
            this.llblEmployee.Name = "llblEmployee";
            this.llblEmployee.Size = new System.Drawing.Size(53, 13);
            this.llblEmployee.TabIndex = 10;
            this.llblEmployee.TabStop = true;
            this.llblEmployee.Text = "Employee";
            this.llblEmployee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblEmployee_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(566, 9);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(119, 13);
            this.linkLabel3.TabIndex = 11;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Employee Total Service";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 557);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.llblEmployee);
            this.Controls.Add(this.llblClose);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.llblAttendence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel llblAttendence;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel llblClose;
        private System.Windows.Forms.LinkLabel llblEmployee;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}

