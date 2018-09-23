using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EmployeeDB
{
    class Employee
    {
        /// <summary>
        /// Employee Name with return type string and getter, setter
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Employee id with return type string and getter, setter
        /// </summary>
        public string EmployeeId { get; set; }

        /// <summary>
        /// Employee CNIC with return type string and getter, setter
        /// </summary>
        public string CNIC { get; set; }

        /// <summary>
        /// Employee appointment date with return type DateTime and getter, setter
        /// </summary>
        public DateTime AppointmentDate { get; set; }

        /// <summary>
        /// Employee Salary with return type double and getter, setter
        /// </summary>
        public double MonthlySalary { get; set; }

        /// <summary>
        /// Employee Email Id with return type string and getter, setter
        /// </summary>
        public string EmailId { get; set; }

        /// <summary>
        /// Employee Mailing Address with return type string and getter, setter
        /// </summary>
        public string MailingAddress { get; set; }

        /// <summary>
        /// Get Gender of Employee from Cnic number.
        /// </summary>
        /// <returns>if even return false else return true</returns>
        public bool GetGender()
        {
            if (CNIC[CNIC.Length - 1] % 2 == 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// this function add all data to the database
        /// </summary>
        /// <param name="attendence">object of Attendence</param>
        public static void MarkAttendence(Attendence attendence)
        {
            int AttendenceId = attendence.AttendenceId;
            DateTime LoginTime = attendence.LoginTime;
            DateTime LogoutTime = attendence.LogoutTime;
            DateTime AttendenceDate = attendence.AttendenceDate;

            string query = string.Format("Insert Into AttendenceRecord(AttendenceId, LogInTime, LogOutTime, AttendenceDate) Values('{0}', '{1}', '{2}', '{3}')", AttendenceId, LoginTime, LogoutTime, AttendenceDate);

            DataBaseConnection.getInstance().executeQuery(query);
        }

        /// <summary>
        /// This function get the total services of employee
        /// </summary>
        /// <param name="employee">string of employee</param>
        /// <returns></returns>
        public string getTotalServices(string employee)
        {
            string query = "Select * from EmployeeData where EmployeeId = '" + employee + "'";
            SqlDataAdapter cmd = new SqlDataAdapter(query, DataBaseConnection.getInstance().getConnection());
            DataTable table = new DataTable();
            cmd.Fill(table);
            string cell = table.Rows[0][4].ToString();
            DateTime date = DateTime.Parse(cell);

            var dt = DateTime.Now;
            //Calculate the years between the dates
            var years = new DateTime(DateTime.Now.Subtract(date).Ticks).Year - 1;
            var pastYear = date.AddYears(years);
            //Calculate the months between the dates
            var months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (pastYear.AddMonths(i) == dt)
                {
                    months = i;
                }
                else if (pastYear.AddMonths(i) >= dt)
                {
                    months = i - 1;
                    break;
                }
            }
            //Calculate the days between the dates
            var days = dt.Subtract(pastYear.AddMonths(months)).Days;

            string d = string.Format("{0} years {1} months {2} days", years, months, days);
            return d;
        }

    }
}
