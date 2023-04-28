using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructProblems
{
    internal class PowerOfTwo
    {
        public void PrintTableOfPowerOfTwo()
        {
            Console.WriteLine("\n**Power Of Two Table**");
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num ; i++)
            {
                Console.WriteLine(Math.Pow(2,i));
            }
        }
    }
}
