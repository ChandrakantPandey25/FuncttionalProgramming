using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class SwapNumber
    {
        public SwapNumber()
        {
            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.Write("Swapped numbers are a= " + a + " b= " + b);
        }
    }
}
