using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructProblems
{
    enum Weekdays
    {
        Sunday = 1,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    public class Weekday
    {
        public void PrintWeekday()
        {
            Console.WriteLine("\n**Print Weekday**");
            Console.Write("Enter a number from 1to 7: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0 && num < 8)
                Console.WriteLine((Weekdays)num);
            else
                Console.WriteLine("Enter only between 1 and 7");

        }
    }
}
