using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
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
        /// List of Attendence of Employees with return type List and getter, setter
        /// </summary>
        public static List<Attendence> AttendenceRecord { get; set; } = new List<Attendence>();
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
            if(CNIC[CNIC.Length -1] % 2 ==0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// This function calculate the Total Service of Employee from its appointment
        /// date to the present date.
        /// </summary>
        /// <returns>Return the string of years, months and days</returns>
        public string GetTotalServices()
        {
            var dt = DateTime.Now;
            //Calculate the years between the dates
            var years = new DateTime(DateTime.Now.Subtract(AppointmentDate).Ticks).Year - 1;
            var pastYear = AppointmentDate.AddYears(years);
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

            string date = string.Format("{0} years {1} months {2} days", years, months, days);
            return date;
        }

        /// <summary>
        /// Mark the attendence of Employees
        /// </summary>
        /// <param name="attendence">Attendence class object</param>
        public void MarkAttendence(Attendence attendence)
        {
            AttendenceRecord.Add(attendence);
        }
    }
}
