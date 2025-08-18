using System;

namespace Fundamentals
{
    class Program
    {

        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] items = values.Split();
            int[] arr = new int[items.Length];
            int rotation = int.Parse(Console.ReadLine());

            for (int i = items.Length - 1; i >= 0; i--)
            {
                if (rotation - arr.Length > 0)
                {
                    rotation = rotation - arr.Length;
                }
                if (i - rotation >= 0)
                {
                    arr[i - rotation] = int.Parse(items[i]);
                }
                else
                {

                    arr[arr.Length + i - rotation] = int.Parse(items[i]);
                }


            }
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }

        }
    }


}

