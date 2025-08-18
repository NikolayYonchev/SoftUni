using System;
using System.Linq;

namespace Fundamentals
{
    //aString 
    //someText
    class Program
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MiddleCharacter(input);
        }

        static void MiddleCharacter(string input)
        {
            if (input.Length % 2 != 0)
            {
                Console.WriteLine(input[input.Length / 2]);
            }
            else
            {
                Console.WriteLine($"{input[input.Length / 2 - 1]}{input[input.Length / 2]} ");
            }
        }
    }
}