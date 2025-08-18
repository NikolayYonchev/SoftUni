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
            string input = "";

            while ((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsPalindrome(input));
            }
        }

        static bool IsPalindrome(string input)
        {
            string first = input.Substring(0, input.Length / 2);
            char[] array = input.ToArray();
            Array.Reverse(array);
            string second = new string(array);
            second = second.Substring(0, input.Length / 2);
            if (first == second)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}