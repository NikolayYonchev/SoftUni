using System;

namespace Fundamentals
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr1 = new string[n];
            string[] arr2 = new string[n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] arrTogether = input.Split();
                if (i % 2 == 0)
                {
                    arr1[i] = arrTogether[0];
                    arr2[i] = arrTogether[0 + 1];
                }
                else
                {
                    arr2[i] = arrTogether[0];
                    arr1[i] = arrTogether[0 + 1];
                }
            }
            foreach (string items in arr1)
            {
                Console.Write($"{items} ");
            }
            Console.WriteLine();
            foreach (string items2 in arr2)
            {
                Console.Write($"{items2} ");
            }



        }
    }


}

