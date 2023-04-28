using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructProblems
{
    public class EvenOrOdd
    {
        public void CheckIfNumberIsEvenOrOdd()
        {
            Console.WriteLine("\n***Even Or Odd***");
            Console.Write("Please Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("Number is Even");
            else
                Console.WriteLine("Number is odd");
        }
    }
}
