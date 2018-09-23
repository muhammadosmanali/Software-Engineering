using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeDB
{
    public partial class PayrollSysetem : Form
    {
        public PayrollSysetem()
        {
            //Connection string which connect to the database
            DataBaseConnection.getInstance().ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\UsmanPC\Documents\EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30";
            InitializeComponent();
        }

        /// <summary>
        /// Bring the form to the front
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManagesEmployees_Click(object sender, EventArgs e)
        {
            AttendenceSystem mngEmp = new AttendenceSystem();
            mngEmp.Show();
            this.Hide();
        }

        /// <summary>
        /// On load it shows the number of employee added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PayrollSysetem_Load(object sender, EventArgs e)
        {
            lblMarkAttendence.Text = countEmpAtt().ToString() + " Employees have Marked";
            lblMarkAtt2.Text = "Attendence Today";
            lblManageEmployees.Text = DataBaseConnection.getInstance().CountRows("EmployeeData") + " Employees have been Added";
        }

        /// <summary>
        /// it bring the form to the front
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMarkAttendence_Click(object sender, EventArgs e)
        {
            MarkAttendence matt = new MarkAttendence();
            matt.Show();
            this.Hide();
        }

        /// <summary>
        /// count the employee who marked the attendence
        /// </summary>
        /// <returns></returns>
        private int countEmpAtt()
        {
            DateTime date = DateTime.Now.Date;
            SqlDataReader reader = DataBaseConnection.getInstance().getData("Select * from AttendenceRecord");
            int count = 0;
            
            while (reader.Read())
            {
                if (date == DateTime.Parse(reader["AttendenceDate"].ToString()))
                {
                    count += 1;
                }
            }
            return count;

        }
    }
}
