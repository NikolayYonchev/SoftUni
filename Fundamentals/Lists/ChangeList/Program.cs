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
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArr = command.Split();
                if (commandArr[0] == "Delete")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == int.Parse(commandArr[1]))
                        {
                            list.Remove(int.Parse(commandArr[1]));

                        }
                    }
                }
                else
                {
                    list.Insert(int.Parse(commandArr[2]), int.Parse(commandArr[1]));
                }
            }
            foreach (int items in list)
            {
                Console.Write(items + " ");
            }
        }
    }
}