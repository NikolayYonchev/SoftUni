using System;
using System.Linq;

namespace Fundamentals
{
    class Program
    {

        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] items = values.Split();
            int[] arr = items.Select(int.Parse).ToArray();
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                counter = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 0;
                        break;
                    }

                }
                if (counter != 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.Write(arr[arr.Length - 1]);

        }
    }


}

