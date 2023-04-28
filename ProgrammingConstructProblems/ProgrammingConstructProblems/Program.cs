using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                Console.Write("\n1.Check number are equal or not\n2.Ever or odd\n3.Eligible for a vote\n4.Largest of Three\n6.Find Weekday\n7.Arithmatic Operations\n8.Power Of Two\n9.Sum Of Squares\n10.Factorial\n11.Flip a coin\n12.Reverse Word\nEnter A Choice: ");

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
                case 3:
                    Voting vote = new Voting();
                    vote.EligibilityForVoting();
                    break;
                case 4:
                    LargestOfThree largest = new LargestOfThree();
                    largest.FindLargestOfThree();
                    break;
                case 6:
                    Weekday obj = new Weekday();
                    obj.PrintWeekday();
                    break;
                case 7:
                    Arithmatic arithmatic = new Arithmatic();
                    arithmatic.Operations();
                    break;
                case 8:
                    PowerOfTwo objOne = new PowerOfTwo();
                    objOne.PrintTableOfPowerOfTwo();
                    break;
                case 9:
                    SumOfSquares objTwo = new SumOfSquares();
                    objTwo.PrintSumOfSquares();
                    break;
                case 10:
                    Factorial factorial= new Factorial(); 
                    factorial.FindFactorial();
                    break;
                case 11:
                    CoinFlip coin = new CoinFlip();
                    coin.FlipCoin();
                    break;
                case 12:
                    Reverse reverse = new Reverse();
                    reverse.ReverseWord();
                    break;
                default:
                    Main();
                    break;
            }
        }
    }
}
