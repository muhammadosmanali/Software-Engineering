using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        /// <summary>
        /// Student Name with return type string, with getter and setters 
        /// </summary>
        public string student_name { get; set; }

        /// <summary>
        /// Registration Number with return type string, with getter and setters
        /// </summary>
        public string reg_number { get; set; }

        /// <summary>
        /// Student Date of Birth with return type DateTime, with getter and setters
        /// </summary>
        public DateTime dob { get; set; }

        /// <summary>
        /// Student CGPA with return type double, with getter and setters
        /// </summary>
        public double cgpa { get; set; }

        /// <summary>
        /// Student CNIC with return type string, with getter and setters
        /// </summary>
        public string cnic { get; set; }

        /// <summary>
        /// Student Hobbies with return type string array, with getter and setters
        /// </summary>
        public string[] hobbies { get; set; }

        /// <summary>
        /// Null constructor of Student class
        /// </summary>
        public Student()
        {
            student_name = "Usman Ali";
            reg_number = "2016-CS-107";
            dob = DateTime.Parse("03/30/1997");
            cgpa = 3.0;
            cnic = "3410175004875";
            hobbies = new string[0];
        }

        /// <summary>
        /// Parameterized Constructor of Student Class
        /// </summary>
        /// <param name="name">It takes the name of student</param>
        /// <param name="regNum">It takes the registration number of student</param>
        public Student(string name, string regNum)
        {
            student_name = name;
            reg_number = regNum;
        }

        /// <summary>
        /// Destructor for student class
        /// </summary>
        ~Student()
        {
            Console.WriteLine("Destructor Called");
        }

        /// <summary>
        /// Check the Student Name contain only Letters and Space
        /// </summary>
        /// <returns>Check the name fullfil the regular expression</returns>
        public bool IsAllLetters()
        {
            return Regex.IsMatch(student_name, "^[a-zA-Z ]+$");
        }

        /// <summary>
        /// Calculate the number of words in the studenet's Name
        /// </summary>
        public void NumberofWordsInName()
        {
            int count = 1;
            foreach(char c in student_name)
            {
                if(c == ' ')
                {
                    count++;
                }
            }
            if(count == 1)
            {
                Console.WriteLine("Name: {0} (Contain {1} word)", student_name, count);
            }
            else if(count > 1)
            {
                Console.WriteLine("Name: {0} (Contain {1} words)", student_name, count);
            }
        }

        /// <summary>
        /// Check the Format of the registration number e.g 2016/CS/107, this function display it as default format i.e 2016-CS-107
        /// </summary>
        public void RegOutput()
        {
            if (reg_number.Length <= 9 && reg_number.All(c => char.IsLetterOrDigit(c)))
            {
                string year = reg_number.Substring(0, 4);
                string department = reg_number.Substring(4, 2);
                string rollNo = reg_number.Substring(6, reg_number.Length - 6);
                string reg = year + "-" + department + "-" + rollNo;
                Console.WriteLine("Registration Number: {0}", reg);
            }
            else if (reg_number.Length <= 11 && reg_number.All(c => char.IsLetterOrDigit(c) || c.Equals('-')))
            {
                Console.WriteLine("Registration Number: {0}", reg_number);
            }
            else
            {
                string newReg = reg_number;
                StringBuilder sb = new StringBuilder(newReg);
                for (int i = 0; i < reg_number.Length; i++)
                {
                    if (reg_number[i] == '_' || reg_number[i] == '/' || reg_number[i] == ',')
                    {
                        sb[i] = '-';
                        newReg = sb.ToString();
                    }
                }
                Console.WriteLine("Registration Number: {0}", newReg);
            }
        }

        /// <summary>
        /// Check the cgpa is in between 0 and 4.
        /// </summary>
        /// <param name="cgpa">Take the Student's CGPA as input</param>
        /// <returns>True if fullfil the conditions else false</returns>
        public bool CheckCGPA(double cgpa)
        {
            if (cgpa > 4 || cgpa < 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Check the CGPA of the Student and display the status of his CGPA
        /// </summary>
        public void GetStatus()
        {
            if(cgpa > 3.5)
            {
                Console.WriteLine("CGPA: {0} Excelent", cgpa);
            }
            else if(cgpa > 3.3 || cgpa == 3.5)
            {
                Console.WriteLine("CGPA: {0} Below Good", cgpa);
            }
            else if(cgpa > 2.5 || cgpa == 3.3)
            {
                Console.WriteLine("CGPA: {0} Average", cgpa);
            }
            else if(cgpa > 2.0 || cgpa == 2.5)
            {
                Console.WriteLine("CGPA: {0} Below Average", cgpa);
            }
            else if(cgpa < 2.0)
            {
                Console.WriteLine("CGPA: {0} Suspended", cgpa);
            }
        }

        /// <summary>
        /// Check the Date of Birth should not be lesser than 1990
        /// </summary>
        /// <returns>if fullfil the condition return true otherwise return false</returns>
        public bool checkDob1()
        {
            if (dob.Year > 1990)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Check the Date of Birth should not be greater than 2005
        /// </summary>
        /// <returns>if fullfil the condition return true otherwise return false</returns>
        public bool checkDob2()
        {
            if(dob.Year < 2005)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Take the input of Date of Birth and Validate it
        /// </summary>
        public void GetDateOfBirth()
        {
            int n = 1;
            for (int i = 0; i < n; i++)
            {
                try
                {
                    Console.Write("Enter Your Date of Birth as mm/dd/yyyy : ");
                    dob = DateTime.Parse(Console.ReadLine());
                    if (!checkDob1() || !checkDob2())
                    {
                        Console.WriteLine("Date of birth should be less than 1st January 2005 and greater than 31st December 1990");
                        n += 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid Date, Please Type Again");
                    n += 1;
                }
            }

        }

        /// <summary>
        /// This function calculate the age of Student using his Date of Birth
        /// </summary>
        public void GetAge()
        {
            string date = dob.ToString("MMMM dd, yyyy");
            var presentDate = DateTime.Now;
            var years = new DateTime(DateTime.Now.Subtract(dob).Ticks).Year - 1;
            var addyears = dob.AddYears(years);
            var month = 0;
            for (int i = 0; i < 12; i++)
            {
                if (addyears.AddMonths(i) == presentDate)
                {
                    month = i;
                }
                else if (addyears.AddMonths(i) >= presentDate)
                {
                    month = i - 1;
                    break;
                }
            }
            var days = presentDate.Subtract(addyears.AddMonths(month)).Days;
            Console.WriteLine(string.Format("Date of Birth: {0} (Age is {1} years {2} months {3} days)", date, years, month, days));
        }

        /// <summary>
        /// Check that the length of CNIC is Ok or not
        /// </summary>
        /// <returns>if length is 13 return true otherwise return false</returns>
        public bool CheckCNIC()
        {
            if (cnic.Length == 13)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get the Gender of student using its last digit of CNIC
        /// If even its Female otherwise Male
        /// </summary>
        public void GetGender()
        {
            char lastDigit = cnic[cnic.Length - 1];
            if (Convert.ToInt32(lastDigit) % 2 == 0)
            {
                Console.WriteLine("Gender: Female");
            }
            else
            {
                Console.WriteLine("Gender: Male");
            }
        }

        /// <summary>
        /// This Method take the input of hobbies 
        /// First ask the User how much hobbies do you have then assign that size to the string array 
        /// and take input of that size
        /// </summary>
        public void Hobbies()
        {
            int x = 1;
            for (int j = 0; j < x; j++)
            {
                try
                {
                    int n;
                    Console.Write("How much hobbies you want to enter: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    hobbies = new string[n];
                    Console.WriteLine("Hobbies: ");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("{0}: ", i + 1);
                        hobbies[i] = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter the interger");
                    x += 1;
                }
            }
        }

        /// <summary>
        /// It display the hobbies of student
        /// </summary>
        public void hobdisplay()
        {
            Console.Write("Hobbies: ");
            string joined = String.Join(", ", hobbies);
            Console.Write(joined);
            Console.WriteLine(" ");
        }

        /// <summary>
        /// It take input of all the data members 
        /// </summary>
        public void Input()
        {
            //Input of Student Name
            int n1 = 1;
            for (int i = 0; i < n1; i++)
            {
                Console.Write("Enter Name: ");
                student_name = Console.ReadLine();
                if (!IsAllLetters())
                {
                    Console.WriteLine("Wrong Input, Please type again");
                    n1 += 1;
                }
            }

            //Input of Registration Number
            int n2 = 1;
            for (int i = 0; i < n2; i++)
            {
                Console.Write("Enter Registration Number as 2016-CS-107: ");
                reg_number = Console.ReadLine();
                if (!(reg_number.Length == 9 || reg_number.Length == 10 || reg_number.Length == 11))
                {
                    Console.WriteLine("Wrong Input, Please type again: ");
                    n2 += 1;
                }
            }

            //Input of CGPA
            int n3 = 1;
            for (int i = 0; i < n3; i++)
            {
                Console.Write("Enter CGPA: ");
                cgpa = Convert.ToDouble(Console.ReadLine());
                if (!CheckCGPA(cgpa))
                {
                    Console.WriteLine("Wrong Input, Please type again: ");
                    n3 += 1;
                }
            }

            //Input of Date of Birth
            GetDateOfBirth();

            //Input of CNIC
            int n4 = 1;
            for(int i = 0; i < n4; i++)
            {
                Console.Write("Enter CNIC: ");
                cnic = Console.ReadLine();
                if(!CheckCNIC())
                {
                    Console.WriteLine("Wrong Input, Please type again: ");
                    n4 += 1;
                }
            }

            //Input of Hobbies
            Hobbies();
        }

        /// <summary>
        /// It Gives the output on console.
        /// </summary>
        public void Tostring()
        {
            //Output of Name
            NumberofWordsInName();

            //Output of Registration Number
            RegOutput();

            //Out put of CGPA
            GetStatus();

            //Output the Date of Birhth
            GetAge();

            //Output the CNIC
            Console.WriteLine("CNIC: {0}", cnic);

            //Output the Gender
            GetGender();

            //Output the Hobbies
            hobdisplay();

            //For line break
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
    }
}
