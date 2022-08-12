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
            Console.WriteLine("Enter 3 for to check Odd or Even");
            Console.WriteLine("Enter 4 for to check Vowel or Consonent");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    QuotientRemainder Result = new QuotientRemainder();
                    break;
                case 2:
                    SwapNumber NewNumber = new SwapNumber();
                    break;
                case 3:
                    EvenOdd resultNew = new EvenOdd();
                    break;
                case 4:
                    VowelConsonent character = new VowelConsonent();
                    break;
                default:
                    Console.WriteLine("Enter the Valid Number");
                    break;
            }
        }
    }
}
