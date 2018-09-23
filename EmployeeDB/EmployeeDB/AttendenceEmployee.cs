using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeDB
{
    public partial class AttendenceEmployee : UserControl
    {
        public AttendenceEmployee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// It shows the attendence record of Employee that you want to know
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckRecord_Click(object sender, EventArgs e)
        {
            dgvAttendenceRecord.DataSource = showData();
            showOnlyTime(1);
            showOnlyTime(2);
        }

        /// <summary>
        /// This is the function used in event handler
        /// </summary>
        /// <returns></returns>
        private DataTable showData()
        {
            string Id = txtId.Text.Substring(4, txtId.Text.Length - 4);
            string query = "Select * from AttendenceRecord where AttendenceId = '" + Id + "'";
            SqlDataAdapter cmd = new SqlDataAdapter(query, DataBaseConnection.getInstance().getConnection());
            DataTable table = new DataTable();
            cmd.Fill(table);
            table.Columns.Remove("Id");
            return table;
        }

        /// <summary>
        /// This function used to show only time instead of full date and time
        /// </summary>
        /// <param name="column"></param>
        private void showOnlyTime(int column)
        {
            dgvAttendenceRecord.Columns[column].DefaultCellStyle.Format = "hh:mm:ss tt";
        }
    }
}
