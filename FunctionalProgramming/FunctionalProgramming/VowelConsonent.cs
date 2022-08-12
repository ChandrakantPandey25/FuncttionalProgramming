using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class VowelConsonent
    {
        public VowelConsonent()
        {
            Console.WriteLine("Enter a character:");
            char input = Char.Parse(Console.ReadLine().ToLower());
            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            {
                Console.WriteLine("It's a vowel");
            }
            else if (input >= 'a' && input <= 'z')
            {

                Console.WriteLine("It's a consonant");
            }
            else
            {
                Console.WriteLine("Invalid input please enter an alphabet");
            }
        }
    }
}
