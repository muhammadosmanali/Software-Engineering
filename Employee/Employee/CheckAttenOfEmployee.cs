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
    public partial class CheckAttenOfEmployee : UserControl
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CheckAttenOfEmployee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On click, it shows the attendence record of desired employee.
        /// </summary>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource = CheckRecord();
            dataGridView1.DataSource = source;
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

        /// <summary>
        /// It check the attendence of an employee
        /// </summary>
        /// <returns>return the attendence of employee</returns>
        private List<Attendence> CheckRecord()
        {
            bool found = false;
            //craete a temporary list
            List<Attendence> tempList = new List<Attendence>();
            int id = Convert.ToInt32(txtEmployeeId.Text.Substring(4, txtEmployeeId.Text.Length - 4));
            //loops through every record of attendence.
            foreach (Attendence attendence in Employee.AttendenceRecord)
            {
                //if present in attendence list it add that attendence to list
                if (id == attendence.AttendenceId)
                {
                    found = true;
                    tempList.Add(attendence);
                    lblmessege.Text = "";
                }
            }
            if (!found)
            {
                lblmessege.Text = "Record Not found";
            }
            return tempList;
        }
    }
}
