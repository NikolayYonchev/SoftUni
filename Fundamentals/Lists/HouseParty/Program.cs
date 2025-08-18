using System;
using System.Linq;
using System.Collections.Generic;
/*
32 54 21 12 4 0 23
75
Add 10
Add 0
30
10
75
end

 */
namespace Fundamentals
{

    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[2] == "going!")
                {
                    if (names.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        names.Add(command[0]);
                    }

                }
                else
                {
                    if (names.Contains(command[0]))
                    {
                        names.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }
            foreach (string guests in names)
            {
                Console.WriteLine(guests);
            }
        }
    }
}