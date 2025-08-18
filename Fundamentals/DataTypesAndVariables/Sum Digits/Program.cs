using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, m;

            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write(sum);
        }
    }
}
