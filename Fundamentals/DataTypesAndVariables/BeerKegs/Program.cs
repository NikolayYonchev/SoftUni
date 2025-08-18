using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            string sumName = "";
            for (int i = 1; i <= n; i++)
            {

                double sum1;
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                sum1 = Math.PI * Math.Pow(radius, 2) * height;
                if (sum1 > sum)
                {
                    sum = sum1;
                    sumName = name;
                }

            }
            Console.WriteLine(sumName);
        }
    }
}
