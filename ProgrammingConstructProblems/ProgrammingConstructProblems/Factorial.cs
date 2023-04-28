using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructProblems
{
    internal class Factorial
    {
        public void FindFactorial()
        {
            Console.WriteLine("\n**Print Factorial**");
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial:  {factorial}");
        }
    }
}
