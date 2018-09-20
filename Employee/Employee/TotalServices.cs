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
    public partial class TotalServices : UserControl
    {
        /// <summary>
        /// COnstructor
        /// </summary>
        public TotalServices()
        {
            InitializeComponent();
        }

        /// <summary>
        /// It return the total service of an desired employee.
        /// </summary>
        private void btnEmployeeService_Click(object sender, EventArgs e)
        {
            bool found = false;
            //loop through every employee in employee list
            foreach(Employee employee in Payroll.getInstance.EmployeeList)
            {
                //check employee id equals to textbox text
                if (txtEmployeeId.Text == employee.EmployeeId)
                {
                    //show messege of the total service of the employee
                    found = true;
                    lblmessege.Text = "Total Service of " + employee.Name + ": " + employee.GetTotalServices();
                }
            }
            if(!found)
            {
                lblmessege.Text = "Employee of " + txtEmployeeId.Text + " not found";
            }
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
