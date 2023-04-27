using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructProblems
{
    public class Number
    {
        public void CheckIfTwoNumbersEqualOrNot()
        {
            Console.WriteLine("\n**Check if numbers are equal or not**");
            Console.Write(">>Enter First Number: ");int num_one = Convert.ToInt32(Console.ReadLine());
            Console.Write(">>Enter Second Number: ");int num_two = Convert.ToInt32(Console.ReadLine());
            if (num_one == num_two)
                Console.WriteLine(">>>>Numbers are equal");
            else
                Console.WriteLine(">>>>Numbers are not equal");
        }
    }
}
