using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDB
{
    public partial class AttendenceSystem : Form
    {
        public AttendenceSystem()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this event bring the usercontrol to the front
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addemp = new AddEmployee();
            this.Controls.Add(addemp);
            addemp.BringToFront();
            
        }

        private void AttendenceSystem_Load(object sender, EventArgs e)
        {
            AddEmployee addemp = new AddEmployee();
            this.Controls.Add(addemp);
            addemp.BringToFront();
        }

        /// <summary>
        /// close the connection when form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AttendenceSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBaseConnection.getInstance().closeConnection();
        }

        /// <summary>
        /// this event bring the form to the front
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            PayrollSysetem ps = new PayrollSysetem();
            ps.Show();
            this.Hide();
        }

        /// <summary>
        /// this event bring the usercontrol to the front
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AttendenceEmployee ae = new AttendenceEmployee();
            this.Controls.Add(ae);
            ae.BringToFront();
        }

        /// <summary>
        /// this event bring the usercontrol to the front
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckServices_Click(object sender, EventArgs e)
        {
            EmployeeServices emp = new EmployeeServices();
            this.Controls.Add(emp);
            emp.BringToFront();
        }

        private void btnShortAttendence_Click(object sender, EventArgs e)
        {
            EmployeeWithShortAttendence emp = new EmployeeWithShortAttendence();
            this.Controls.Add(emp);
            emp.BringToFront();
        }
    }
}
