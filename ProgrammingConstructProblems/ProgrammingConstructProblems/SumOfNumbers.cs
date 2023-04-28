using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructProblems
{
    internal class SumOfNumbers
    {
        public void SumOfNarualNumbers()
        {
            int num = 5;
            int sum = 0;
            int i = 1;
            while (i <= 5)
            {
                sum += i;
                i++;
            }
            Console.WriteLine($"\n>>Sum of first 5 natural number : {sum} ");
        }
    }
}
