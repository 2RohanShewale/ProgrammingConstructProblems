using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructProblems
{
    internal class LargestOfThree
    {
        public void FindLargestOfThree()
        {
            Console.WriteLine("\n**Largest Of Three**");
            Console.Write("Enter first number: ");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Numer: ");
            int numThree = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            if (numOne > max)
                max = numOne;
            if (numTwo > max)
                max = numTwo;
            if (numThree > max)
                max = numThree;
            Console.WriteLine($">>>Largest number: {max}");
        }
    }
}
