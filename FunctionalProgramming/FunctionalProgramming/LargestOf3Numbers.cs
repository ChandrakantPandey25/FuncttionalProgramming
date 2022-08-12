using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class LargestOf3Numbers
    {
        public LargestOf3Numbers()
        {

           


            Console.Write("Input the 1st number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write(" greatest among three is :" + num1);
                }
                else
                {
                    Console.Write(" greatest among three is :" + num2);
                }
            }
            else if (num2 > num3)
                Console.Write(" greatest among three is: " + num2);
            else
                Console.Write("greatest among three is: " + num3);
        }
    }
}
