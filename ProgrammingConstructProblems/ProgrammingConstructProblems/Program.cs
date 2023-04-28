using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstructProblems
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\\******Programming Construct Problem******/");
                Console.Write("\n1.Check number are equal or not\n2.Ever or odd\nEnter A Choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                ChooseProgram(choice);
            }      
        }
        public static void ChooseProgram(int choice)
        {
            switch (choice)
            {
                case 1:
                    Number number = new Number();
                    number.CheckIfTwoNumbersEqualOrNot();
                    break;
                case 2:
                    EvenOrOdd evenOr = new EvenOrOdd();
                    evenOr.CheckIfNumberIsEvenOrOdd();
                    break;
                default:
                    Main();
                    break;
            }
        }
    }
}
