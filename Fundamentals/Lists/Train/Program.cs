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
            int wagonCapacity = int.Parse(Console.ReadLine());
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputSplit = input.Split();
                if (inputSplit[0] == "Add")
                {

                    list.Add(int.Parse(inputSplit[1]));
                }
                else
                {

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] + int.Parse(inputSplit[0]) <= wagonCapacity)
                        {
                            list[i] += int.Parse(inputSplit[0]);
                            break;
                        }

                    }
                }

            }
            foreach (int nums in list)
            {
                Console.Write(nums + " ");
            }
        }
    }
}