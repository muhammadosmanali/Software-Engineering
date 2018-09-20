using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Payroll
    {
        /// <summary>
        /// A private constructor for Payroll class
        /// </summary>
        private Payroll() 
        {
         
        }

        /// <summary>
        /// EmployeeList which contain the list of employees.
        /// Getter and Setter are also formed.
        /// </summary>
        public List<Employee> EmployeeList { get; set; } = new List<Employee>();

        /// <summary>
        /// Make a Private instance of Payroll class.
        /// </summary>
        private static Payroll Instance = null;

        /// <summary>
        /// This function add the employees to the EmployeeList.
        /// </summary>
        /// <param name="employee">It takes Employee class object as a parameter</param>
        public void addEmployee(Employee employee)
        {
            EmployeeList.Add(employee);
        }

        /// <summary>
        /// LitOfEmployees function with return type list.
        /// </summary>
        /// <returns>It return the List of employees present in the list.</returns>
        public List<Employee> ListOfEmployees()
        {
            return EmployeeList;
        }

        /// <summary>
        /// This function collect the list of employees which had short attendence.
        /// </summary>
        /// <param name="startDate">Give the date as input from where you start to check the attendence shortage of employee</param>
        /// <param name="endDate">It's a date where end the date of checking the short attendence.</param>
        /// <returns>Return the list of employees with short attendence</returns>
        public List<Employee> ListofEMployeesWithShortAttendence(DateTime startDate, DateTime endDate)
        {
            List<Employee> tempList = new List<Employee>();
            //It gives total days between the dates
            int days = Convert.ToInt32((endDate.Date - startDate.Date).Days);
            int totaldays = days;
            //It removes the saturday and sunday from the date.
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

            //Total working hours of an employee
            int totalTime = totaldays * 8;

            int count = 0;
            //Loop through every employee
            foreach (Employee emp in Payroll.getInstance.EmployeeList)
            {
                //Convert the employee id to integer
                int id = Convert.ToInt32(emp.EmployeeId.Substring(4, emp.EmployeeId.Length - 4));
                //Loop through every attendence record
                foreach (Attendence attendence in Employee.AttendenceRecord)
                {
                    //check that id is present in attendence record or not
                    if (attendence.AttendenceId == id)
                    {
                        //check that attendence date should be equal or greater than startdate
                        if (DateTime.Compare(attendence.AttendenceDate.Date, startDate.Date) >= 0)
                        {
                            //check that attendence date should be equal or less than enddate
                            if (DateTime.Compare(attendence.AttendenceDate.Date, endDate.Date) <= 0)
                            {
                                //it calcaulte the hours between the times.
                                int hours = attendence.LogoutTime.Subtract(attendence.LoginTime).Hours;
                                count += hours;
                            }
                        }
                    }
                //Check if employee working hours less than total working hours
                //then add that employee to the list 
                }
                if (count < totalTime && count > 0)
                {
                    tempList.Add(emp);
                }
            }
            //return that list
            return tempList;
        }

        /// <summary>
        /// getInstance form the object of class if it's null and return that object.
        /// </summary>
        public static Payroll getInstance
        {
            get
            {
                if(Instance == null)
                {
                    Instance = new Payroll();
                }
                return Instance;
            }
        }

    }
}
