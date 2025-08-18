using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLitres = 0;
            for (int i = 0; i < n; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                sumLitres += litres;
                if (sumLitres > 255)
                {
                    sumLitres -= litres;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(sumLitres);
        }
    }
}
