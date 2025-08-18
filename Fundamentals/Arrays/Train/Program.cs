using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ppl = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                ppl[i] = int.Parse(Console.ReadLine());
                Console.Write(ppl[i] + " ");
                sum += ppl[i];
            }
            Console.WriteLine();
            Console.WriteLine(sum);

        }
    }


}

