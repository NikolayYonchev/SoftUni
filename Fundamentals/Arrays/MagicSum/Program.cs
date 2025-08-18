using System;
using System.Linq;

namespace Fundamentals
{
    /*
1 7 6 2 19 23
8
     */
    class Program
    {

        static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine().Split();
            int[] numbers = symbols.Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == n)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]}");
                        break;
                    }

                }
            }
        }
    }
}

