using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
/*


 */
namespace Fundamentals
{

    internal class Program
    {
        static void Main(string[] arguments)
        {
            string input = Console.ReadLine();

            string result = ReplaceRepeatedCharacters(input);
            Console.WriteLine(result);

        }
        static string ReplaceRepeatedCharacters(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            string result = input[0].ToString();

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    result += input[i];
                }
            }

            return result;
        }
    }
}
