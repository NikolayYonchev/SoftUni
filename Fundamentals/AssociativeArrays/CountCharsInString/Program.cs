using System;
using System.Linq;
using System.Collections.Generic;
/*


 */
namespace Fundamentals
{


    class Program
    {
        static void Main(string[] arguments)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Dictionary<char, int> charOccurences = new Dictionary<char, int>();



            foreach (var item in input)
            {
                for (int j = 0; j < item.Length; j++)
                {
                    char character = item[j];

                    if (!charOccurences.ContainsKey(character))
                    {
                        charOccurences.Add(character, 1);
                    }
                    else
                    {
                        charOccurences[character]++;
                    }
                }
            }


            foreach (KeyValuePair<char, int> item in charOccurences)
            {
                char character = item.Key;
                int value = item.Value;
                Console.WriteLine($"{character} -> {value}");
            }
        }
    }
}
