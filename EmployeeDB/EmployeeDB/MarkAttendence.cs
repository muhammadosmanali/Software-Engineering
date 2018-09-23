using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDB
{
    public partial class MarkAttendence : Form
    {
        private int id;
        private DateTime logInTime;

        public MarkAttendence()
        {
            InitializeComponent();
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        /// <summary>
        /// when button click it save the id and date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            int check = DataBaseConnection.getInstance().alreadyPresentInDB(txtId.Text, "EmployeeData", "EmployeeId");
            if(check > 0)
            {
                id = Convert.ToInt32(txtId.Text.Substring(4, txtId.Text.Length - 4));
                logInTime = DateTime.Now;
                lblMessege.Text = "";
       
            }
            else
            {
                lblMessege.Text = "There is no employee of this ID";
            }
            
        }

        /// <summary>
        /// When event clicked it add the data to the datatable of database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Attendence attendence = new Attendence();
            int check = DataBaseConnection.getInstance().alreadyPresentInDB(txtId.Text, "EmployeeData", "EmployeeId");
            if (check > 0)
            {
                attendence.AttendenceId = id;
                attendence.LoginTime = logInTime;
                attendence.LogoutTime = DateTime.Now;
                attendence.AttendenceDate = DateTime.Now.Date;
                Employee.MarkAttendence(attendence);
                dgvAttendenceRecord.DataSource = DataBaseConnection.getInstance().ShowData("AttendenceRecord");
                showOnlyTime(1);
                showOnlyTime(2);
                lblMessege.Text = "";

            }
            else
            {
                lblMessege.Text = "There is no employee of this ID";
            }
        }

        /// <summary>
        /// On load it shows the data in datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MarkAttendence_Load(object sender, EventArgs e)
        {
            dgvAttendenceRecord.DataSource = DataBaseConnection.getInstance().ShowData("AttendenceRecord");
            showOnlyTime(1);
            showOnlyTime(2);
        }

        private void lblEmployeeId_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// check the employee id correct or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.All(c => c.Equals('E') || c.Equals('m') || c.Equals('p') || c.Equals('-') || char.IsDigit(c)))
            {
                lblMessege.Text = "";
            }
            else
            {
                lblMessege.Text = "Please type in format: Emp-1";
            }
        }

        private void showOnlyTime(int column)
        {
            dgvAttendenceRecord.Columns[column].DefaultCellStyle.Format = "hh:mm:ss tt";
        }

        /// <summary>
        /// move back to main page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            PayrollSysetem ps = new PayrollSysetem();
            ps.Show();
            this.Hide();
        }
    }
}
