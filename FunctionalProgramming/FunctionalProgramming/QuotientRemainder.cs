using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class QuotientRemainder
    {
        public QuotientRemainder()
        {
            Console.WriteLine("Enter the dividend");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the diviser");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            int quotient = Num1 / Num2;
            int remainder = Num1 % Num2;
            Console.WriteLine("Quotient is:" + quotient);
            Console.WriteLine("Remainder is:" + remainder);

        }
    }
}
