using System;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Functional Core Programming");
            Console.WriteLine("Enter 1 for Quotient Remainder");
            Console.WriteLine("Enter 2 for Swapping two numbers");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    QuotientRemainder Result = new QuotientRemainder();
                    break;
                case 2:
                    SwapNumber NewNumber = new SwapNumber();
                    break;
                default:
                    Console.WriteLine("Enter the Valid Number");
                    break;
            }
        }
    }
}
