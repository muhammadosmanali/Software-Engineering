namespace EmployeeDB
{
    partial class AttendenceEmployee
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
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCheckRecord = new System.Windows.Forms.Button();
            this.dgvAttendenceRecord = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendenceRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(259, 69);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(85, 20);
            this.lblEmployeeId.TabIndex = 3;
            this.lblEmployeeId.Text = "Employee Id";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(417, 64);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(206, 25);
            this.txtId.TabIndex = 2;
            // 
            // btnCheckRecord
            // 
            this.btnCheckRecord.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnCheckRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheckRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCheckRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckRecord.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckRecord.Location = new System.Drawing.Point(500, 121);
            this.btnCheckRecord.Name = "btnCheckRecord";
            this.btnCheckRecord.Size = new System.Drawing.Size(123, 40);
            this.btnCheckRecord.TabIndex = 4;
            this.btnCheckRecord.Text = "Check Record";
            this.btnCheckRecord.UseVisualStyleBackColor = true;
            this.btnCheckRecord.Click += new System.EventHandler(this.btnCheckRecord_Click);
            // 
            // dgvAttendenceRecord
            // 
            this.dgvAttendenceRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendenceRecord.Location = new System.Drawing.Point(245, 243);
            this.dgvAttendenceRecord.Name = "dgvAttendenceRecord";
            this.dgvAttendenceRecord.Size = new System.Drawing.Size(448, 159);
            this.dgvAttendenceRecord.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Attendence Record:";
            // 
            // AttendenceEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAttendenceRecord);
            this.Controls.Add(this.btnCheckRecord);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.txtId);
            this.Location = new System.Drawing.Point(0, 50);
            this.Name = "AttendenceEmployee";
            this.Size = new System.Drawing.Size(899, 473);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendenceRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCheckRecord;
        private System.Windows.Forms.DataGridView dgvAttendenceRecord;
        private System.Windows.Forms.Label label1;
    }
}
