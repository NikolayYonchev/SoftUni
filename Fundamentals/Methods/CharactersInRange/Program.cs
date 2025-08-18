using System;
using System.Linq;



public class Program
{
    public static void PrintCharactersBetween(char char1, char char2)
    {
        int start = Math.Min(char1, char2);
        int end = Math.Max(char1, char2);

        for (int i = start + 1; i < end; i++)
        {
            Console.Write((char)i + " ");
        }
    }

    public static void Main()
    {
        char char1 = char.Parse(Console.ReadLine());
        char char2 = char.Parse(Console.ReadLine());
        PrintCharactersBetween(char1, char2);
    }
}


