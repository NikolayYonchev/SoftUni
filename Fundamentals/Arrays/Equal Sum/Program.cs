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
            int satisfier = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int left = 0; left <= i; left++)
                {
                    if (left == i)
                    {
                        continue;
                    }
                    leftSum += numbers[left];

                }
                for (int right = i + 1; right < numbers.Length; right++)
                {
                    if (right == i)
                    {
                        continue;
                    }
                    rightSum += numbers[right];
                }
                if (leftSum == rightSum)
                {
                    satisfier++;
                    Console.WriteLine(i);
                }

            }
            if (satisfier == 0)
            {
                Console.WriteLine("no");
            }
        }
    }
}

