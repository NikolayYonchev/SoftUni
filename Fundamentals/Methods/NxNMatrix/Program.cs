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
            int input = int.Parse(Console.ReadLine());
            Matrix(input);
        }

        static void Matrix(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= input; j++)
                {
                    Console.Write(input + " ");
                }
                Console.WriteLine();
            }
        }
    }
}