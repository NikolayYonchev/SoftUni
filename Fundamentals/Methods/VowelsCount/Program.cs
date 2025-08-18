using System;
using System.Linq;

namespace Fundamentals
{

    class Program
    {

        static void Main(string[] args)
        {
            SmallestNumber(Console.ReadLine());
        }
        static void SmallestNumber(string input)
        {
            int counter = 0;
            input = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {

                switch (input[i])
                {
                    case 'a':
                        counter++;
                        break;
                    case 'e':
                        counter++;
                        break;
                    case 'o':
                        counter++; ;
                        break;
                    case 'i':
                        counter++;
                        break;
                    case 'u':
                        counter++;
                        break;
                }

            }
            Console.WriteLine(counter);
        }
    }
}

