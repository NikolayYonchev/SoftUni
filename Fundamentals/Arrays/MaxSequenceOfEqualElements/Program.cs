using System;
using System.Linq;

namespace Fundamentals
{
    /*
     *2 1 1 2 3 3 2 2 2 1 
     *1 1 1 2 3 1 3 3 
     *0 1 1 5 2 2 6 3 3 
     */
    class Program
    {

        static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine().Split();
            int[] numbers = symbols.Select(int.Parse).ToArray();
            int counter = 0;
            int bestCount = 0;
            string bestCountSymbol = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                counter = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        counter++;
                        if (counter > bestCount)
                        {
                            bestCount = counter;
                            bestCountSymbol = symbols[j];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(bestCountSymbol + " ");
            }

        }


    }


}

