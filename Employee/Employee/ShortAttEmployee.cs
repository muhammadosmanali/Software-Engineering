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
    public partial class ShortAttEmployee : UserControl
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ShortAttEmployee()
        {
            InitializeComponent();
        }

        private void ShortAttEmployee_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// it shows the employee list with short attendence in datagridview
        /// </summary>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource = Payroll.getInstance.ListofEMployeesWithShortAttendence(dtpStartDate.Value, dtpEndDate.Value);
            dataGridView1.DataSource = source;
        }
    }
}
