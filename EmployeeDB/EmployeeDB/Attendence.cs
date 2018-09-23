using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDB
{
    class Attendence
    {
        /// <summary>
        /// Attendence ID with return type int and getter, setters.
        /// </summary>
        public int AttendenceId { get; set; }
        /// <summary>
        /// Employee login time with return type DateTime and getter, setters.
        /// </summary>
        public DateTime LoginTime { get; set; }
        /// <summary>
        /// Employee logout time with return type DateTime and getter, setters.
        /// </summary>
        public DateTime LogoutTime { get; set; }
        /// <summary>
        /// Attendence Date with return type DateTime and getter, setters.
        /// </summary>
        public DateTime AttendenceDate { get; set; }
    }
}
