using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructProblems
{
    internal class Reverse
    {
        public void ReverseWord()
        {
            Console.WriteLine("\n**reverse The word**");
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            int wordLength = word.Length -1;
            string reversedWord = "";
            while (wordLength>=0)
            {
                reversedWord += word[wordLength];
                wordLength--;
            }
            Console.WriteLine(">>>"+reversedWord);
        }
    }
}
