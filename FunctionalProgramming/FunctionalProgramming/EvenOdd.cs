using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class EvenOdd
    {
        public EvenOdd()
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");

            }
            else
            {
                Console.Write("Entered Number is an Odd Number");

            }
        }
    }
}
