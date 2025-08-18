using System;
using System.Linq;

namespace Fundamentals
{
    //aString 
    //someText
    class Program
    {

        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine((Factorial(num1) / Factorial(num2)).ToString("F2"));
        }

        private static double Factorial(int number)
        {

            double sum = 1;
            for (int i = 1; i <= number; i++)
            {
                sum = sum * i;
            }
            return sum;
        }
    }


}