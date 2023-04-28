using System;

namespace ProgrammingConstructProblems
{
    internal class Arithmatic
    {
        public void Operations()
        {
            Console.WriteLine("\n**Perform Arithmatic operation**");
            Console.Write("Enter first number: ");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Opraritions:\n1.Addition\n2.Subtraction\n3.Division\n4.Multiplication\n5.Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($">>Addition: {numOne + numTwo}");
                    break;
                case 2:
                    Console.WriteLine($">>Subtraction: {numOne - numTwo}");
                    break;
                case 3:
                    Console.WriteLine($">>Divison: {numOne / numTwo}");
                    break;
                case 4:
                    Console.WriteLine($">>Multiplication: {numOne * numTwo}");
                    break;
                default:
                    Console.WriteLine(">>>Invalid Choice");
                    break;
            }
        }
    }
}
