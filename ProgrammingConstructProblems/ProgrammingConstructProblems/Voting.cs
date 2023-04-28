using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructProblems
{
    public class Voting
    {
        public void EligibilityForVoting()
        {
            Console.WriteLine("\n***Check if candidate is eligable for voting***");
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age>= 18)
                Console.WriteLine(">>You are eligible for voting");
            else
                Console.WriteLine(">>You are not eligible for voting");
        }
    }
}
