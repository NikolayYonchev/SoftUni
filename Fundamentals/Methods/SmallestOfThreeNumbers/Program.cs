using System;
using System.Linq;

namespace Fundamentals
{

    class Program
    {

        static void Main(string[] args)
        {
            SmallestNumber(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }
        static void SmallestNumber(int a, int b, int c)
        {

            if (a < b && a < c)
            {
                Console.WriteLine(a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}

