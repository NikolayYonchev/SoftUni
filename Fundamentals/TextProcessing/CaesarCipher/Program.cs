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
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            char[] encryptedChars = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char originalChar = text[i];

                sb.Append((char)(originalChar + 3));
            }

            Console.WriteLine(sb);

        }
    }
}
