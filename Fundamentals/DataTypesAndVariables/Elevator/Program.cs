using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, p;
            n = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            int output = 0;

            if (n % p == 0)
            {
                output = n / p;
            }
            else
            {
                output += n / p;
                int leftover = n % p;
                if (leftover < p)
                {
                    output++;
                }
                else
                {
                    output += leftover / p;
                }
            }
            Console.WriteLine(output);

        }
    }
}
