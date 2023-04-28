using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructProblems
{
    internal class CoinFlip
    {
        Random random = new Random();
        int headCount = 0;
        int tailCount = 0;
        public void FlipCoin()
        {
            Console.WriteLine("\n**Coin Flip Program**");
            Console.WriteLine("Press any key to flip coin");
            Console.ReadKey();
            while (headCount<20 && tailCount < 20)
            {
                int num = random.Next(1,3);
                if (num == 1)
                {
                    Console.WriteLine("Heads");
                    headCount++;
                }
                else if (num == 2)
                {
                    Console.WriteLine("Tails");
                    tailCount++;
                }
            }
            Console.WriteLine(headCount + " " + tailCount);
        }
    }
}
