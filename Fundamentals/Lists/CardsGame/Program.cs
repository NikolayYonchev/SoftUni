using System;
using System.Linq;
using System.Collections.Generic;
/*

20 30 40 50
10 20 30 40               
                    


 */
namespace Fundamentals
{

    class Program
    {

        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> player2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            int winningCount = player1.Count;

            while (player1.Count > 0 && player2.Count > 0)
            {
                if (player1[0] > player2[0])
                {
                    player1.Add(player2[0]);
                    player1.Add(player1[0]);
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);

                }
                else if (player1[0] < player2[0])
                {
                    player2.Add(player1[0]);
                    player2.Add(player2[0]);
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }
                else//ako sa ravni
                {
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }


            }
            int sum = 0;
            if (player1.Count > player2.Count)
            {
                foreach (int items in player1)
                {
                    sum += items;

                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                foreach (int items in player2)
                {
                    sum += items;

                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}