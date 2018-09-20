using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Attendencess : UserControl
    {
        //Create the object of attendence
        Attendence attendence;
        //Initialize to set the it to the logintime of employee
        DateTime loginTime;
        //Initialize to set the it to the id of employee
        int id;
        /// <summary>
        /// Constructor
        /// </summary>
        public Attendencess()
        {
            InitializeComponent();
        }

        /// <summary>
        /// It collect the login time and id of employee when click the event
        /// </summary>
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool found = false;
            //Loop through every employee in employee list
            foreach (Employee employee in Payroll.getInstance.EmployeeList)
            {
                //it checks that employee id is equal to textbox text.
                if (employee.EmployeeId == txtEmployeeId.Text)
                {
                    found = true;
                    loginTime = DateTime.Now;
                    id = Convert.ToInt32(txtEmployeeId.Text.Substring(4, txtEmployeeId.Text.Length - 4));
                    lblmessege.Text = "";
                    btnLogout.Enabled = true;
                }
            }
            if (!found)
            {
                lblmessege.Text = "Not Found!";
            }
        }

        /// <summary>
        /// This function add data of attendence to the attendence record
        /// </summary>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Loop through every employee in employee list
            foreach (Employee employee in Payroll.getInstance.EmployeeList)
            {
                //it checks that employee id is equal to textbox text.
                if (employee.EmployeeId == txtEmployeeId.Text)
                {
                    //Form object of attendence
                    //set attendence data members to textboxes text
                    //Add them to attendence record
                    //And show them to the Data Grid View
                    attendence = new Attendence();
                    attendence.AttendenceId = id;
                    attendence.LoginTime = loginTime;
                    attendence.LogoutTime = DateTime.Now;
                    attendence.AttendenceDate = DateTime.Now;

                    Employee.AttendenceRecord.Add(attendence);

                    BindingSource source = new BindingSource();
                    source.DataSource = Employee.AttendenceRecord;
                    dgvAttendence.DataSource = source;
                }
            }
            btnLogout.Enabled = false;
        }

        /// <summary>
        /// On page load it shows the list of attendence in datagridview
        /// </summary>
        private void Attendencess_Load(object sender, EventArgs e)
        {   
            btnLogout.Enabled = false;
            BindingSource source = new BindingSource();
            source.DataSource = Employee.AttendenceRecord;
            dgvAttendence.DataSource = source;
        }

        /// <summary>
        /// Check the format of employee Id
        /// </summary>
        private void txtEmployeeId_TextChanged(object sender, EventArgs e)
        {
            if (txtEmployeeId.Text.All(c => c.Equals('E') || c.Equals('m') || c.Equals('p') || c.Equals('-') || char.IsDigit(c)))
            {
                lblmessege.Text = "";
            }
            else
            {
                lblmessege.Text = "Please type in format: Emp-1";
            }
        }
    }
}
