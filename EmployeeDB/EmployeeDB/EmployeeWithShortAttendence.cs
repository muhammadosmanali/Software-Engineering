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
    public partial class EmployeeWithShortAttendence : UserControl
    {
        public EmployeeWithShortAttendence()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            dgvShortAttendence.DataSource = Payroll.getInstance.employeeWithShortAttendence(dtpStartDate.Value.Date, dtpEndDate.Value.Date);
        }
    }
}
