using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EmployeeDB
{
    class Payroll
    {
        //Create the private instance of class
        private static Payroll Instance;

        /// <summary>
        /// Private constructor
        /// </summary>
        private Payroll()
        {

        }

        /// <summary>
        /// Create the instance of the class
        /// </summary>
        public static Payroll getInstance
        {
            get
            {
                if (Instance == null)
                    Instance = new Payroll();
                return Instance;
            }
        }

        /// <summary>
        /// this function add employee data to the database
        /// </summary>
        /// <param name="employee"></param>
        public void addEmployee(Employee employee)
        {
            string name = employee.Name;
            string empId = employee.EmployeeId;
            string cnic = employee.CNIC;
            DateTime date = employee.AppointmentDate;
            string salary = employee.MonthlySalary.ToString();
            string email = employee.EmailId;
            string address = employee.MailingAddress;

            string query = String.Format("INSERT INTO EmployeeData(EmployeeId, Name, Cnic, AppointmentDate, Salary, Email, MailingAddress) values('{0}','{1}', '{2}', '{3}', '{4}', '{5}', '{6}' )", empId, name, cnic, date, salary, email, address);
            
            int row = DataBaseConnection.getInstance().executeQuery(query);
        }

        /// <summary>
        /// this function contain the lists of employees
        /// </summary>
        /// <returns>return the table which contain the data</returns>
        public DataTable ListOfEmployee()
        {
            DataTable table = DataBaseConnection.getInstance().ShowData("EmployeeData");
            return table;
        }

        public List<Employee> employeeWithShortAttendence(DateTime startDate, DateTime endDate)
        {
            int days = Convert.ToInt32((endDate.Date - startDate.Date).Days);
            int totaldays = days;
            for (int i = 0; i < days; i++)
            {
                if (startDate.DayOfWeek == DayOfWeek.Saturday || startDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    startDate = startDate.AddDays(1);
                    totaldays -= 1;

                }
                else
                {
                    startDate = startDate.AddDays(1);
                }
            }
            int workingHours = totaldays * 8;

            List<Employee> list = new List<Employee>();
            Employee employee = new Employee();

            SqlDataAdapter cmd2 = new SqlDataAdapter("Select * from AttendenceRecord", DataBaseConnection.getInstance().getConnection());
            SqlDataAdapter cmd1 = new SqlDataAdapter("Select EmployeeId from EmployeeData", DataBaseConnection.getInstance().getConnection());

            DataTable table1 = new DataTable();
            cmd1.Fill(table1);

            DataTable table2 = new DataTable();
            cmd2.Fill(table2);

            int count = 0;
            for (int j = 0; j < DataBaseConnection.getInstance().CountRows("EmployeeData"); j++)
            {
                for(int k = 0; k < DataBaseConnection.getInstance().CountRows("AttendenceRecord"); k++)
                {
                    string id = "Emp-" + table2.Rows[k][table2.Columns.Count - 4].ToString();
                    if(table1.Rows[j].ToString() == id)
                    {
                        DateTime attDate = DateTime.Parse(table2.Rows[k][table2.Columns.Count - 1].ToString());
                        if(attDate >= startDate.Date && attDate <= endDate.Date)
                        {
                            DateTime logInTime = DateTime.Parse(table2.Rows[k][table2.Columns.Count - 3].ToString());
                            DateTime logOutTime = DateTime.Parse(table2.Rows[k][table2.Columns.Count - 2].ToString());
                            int hours = (logOutTime - logInTime).Hours;
                            count += hours;
                        }
                    }
                }
                if(count < workingHours && count > 0)
                {
                    employee.EmployeeId = table1.Rows[j].ToString();
                    list.Add(employee);
                }
            }

            return list;

        }
    }
}
