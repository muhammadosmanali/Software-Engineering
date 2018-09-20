using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student obj = new Student();
            ////Student obj2 = new Student("Usman", "2016CS107");
            //obj.Input();
            //System.Console.Clear();
            //obj.Tostring();

            //DateTime time1 = DateTime.Parse(Console.ReadLine());
            //DateTime time2 = DateTime.Now;

            //int res = new DateTime(time2.Subtract(time1).Ticks).Hour - 1;

            //Console.WriteLine(res);

            DateTime endDate = DateTime.Now;

            DateTime startDate = DateTime.Parse(Console.ReadLine());

            int days = Convert.ToInt32((endDate.Date - startDate.Date).Days) + 1;
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
            Console.WriteLine(days);

        }
    }
}
