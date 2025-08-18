using System;
using System.Linq;
using System.Collections.Generic;
/*
1 23 29 18 43 21 20
Add 5
Remove 5
Shift left 3
Shift left 1
End


 */
namespace Fundamentals
{

    class Program
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> list = new List<int>();
            list = input.Split().Select(int.Parse).ToList();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArr = command.Split();
                switch (commandArr[0])
                {
                    case "Add":
                        list = AddNumber(list, int.Parse(commandArr[1]));
                        break;
                    case "Insert":
                        list = InsertNumber(list, int.Parse(commandArr[1]), int.Parse(commandArr[2]));
                        break;
                    case "Remove":
                        list = RemoveNumber(list, int.Parse(commandArr[1]));
                        break;
                    case "Shift":
                        switch (commandArr[1])
                        {
                            case "left":
                                list = ShiftLeft(list, int.Parse(commandArr[2]));
                                break;
                            case "right":
                                list = ShiftRight(list, int.Parse(commandArr[2]));
                                break;
                        }
                        break;
                }
            }
            foreach (int items in list)
            {
                Console.Write(items + " ");
            }

        }
        static List<int> AddNumber(List<int> list, int number)
        {
            list.Add(number);
            return list;
        }
        static List<int> InsertNumber(List<int> list, int number, int index)
        {
            if (index > list.Count - 1 || index < 0)
            {
                Console.WriteLine("Invalid index");
                return list;
            }
            list.Insert(index, number);
            return list;
        }
        static List<int> RemoveNumber(List<int> list, int index)
        {
            if (index > list.Count - 1 || index < 0)
            {
                Console.WriteLine("Invalid index");
                return list;
            }
            list.RemoveAt(index);
            return list;
        }
        static List<int> ShiftRight(List<int> list, int count)
        {
            count = count % list.Count;
            List<int> shifted = list.GetRange(list.Count - count, count);
            list.RemoveRange(list.Count - count, count);
            list.InsertRange(0, shifted);
            return list;
        }
        static List<int> ShiftLeft(List<int> list, int count)
        {
            count = count % list.Count;
            List<int> shifted = list.GetRange(0, count);
            list.RemoveRange(0, count);
            list.InsertRange(list.Count, shifted);
            return list;
        }

    }


}