using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDB
{
    public partial class EmployeeServices : UserControl
    {
        public EmployeeServices()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this event return the total services of employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckServices_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            lblMessege.Text = emp.getTotalServices(txtId.Text);
        }
    }
}
