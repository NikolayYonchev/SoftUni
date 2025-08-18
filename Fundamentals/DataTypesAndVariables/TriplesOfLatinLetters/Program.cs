using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int endchar = 97 + n;
            for (int i = 97; i < endchar; i++)
            {
                for (int j = 97; j < endchar; j++)
                {
                    for (int p = 97; p < endchar; p++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)p}");
                    }

                }
            }

        }
    }
}
