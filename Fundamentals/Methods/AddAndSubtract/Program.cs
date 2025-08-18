using System;
using System.Linq;

namespace Fundamentals
{

    class Program
    {

        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = SumDigits(a, b);
            int substract = SubstractDigits(sum, c);
            Console.WriteLine(substract);
        }

        static int SumDigits(int a, int b)
        {
            return a + b;
        }
        static int SubstractDigits(int sum, int c)
        {
            return sum - c;
        }
    }
}