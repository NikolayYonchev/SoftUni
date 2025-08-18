using System;
using System.Linq;
using System.Collections.Generic;
/*


 */
namespace Fundamentals
{


    class Program
    {
        static void Main(string[] arguments)
        {
            Dictionary<string, int> resourceMap = new Dictionary<string, int>();

            string resource;
            int quantity;
            while ((resource = Console.ReadLine()) != "stop")
            {
                quantity = int.Parse(Console.ReadLine());
                if (resourceMap.ContainsKey(resource))
                {
                    resourceMap[resource] += quantity;
                }
                else
                {
                    resourceMap.Add(resource, quantity);
                }

            }

            foreach (KeyValuePair<string, int> item in resourceMap)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

    }
}
