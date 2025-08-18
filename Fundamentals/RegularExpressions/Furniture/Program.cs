using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
/*


*/
namespace Fundamentals
{
    class Furniture
    {
        public Furniture(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal Total()
        {
            return Price * Quantity;
        }
    }

    internal class Program
    {
        static void Main(string[] arguments)
        {
            List<Furniture> furnitures = new List<Furniture>();
            string input;
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+|\d+\.\d+)!(?<quantity>\d+)";

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Regex r = new Regex(pattern);
                MatchCollection collection = r.Matches(input);

                foreach (Match match in collection)
                {

                    string name = match.Groups["name"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    Furniture f = new Furniture(name, price, quantity);
                    furnitures.Add(f);
                }
            }
            Console.WriteLine("Bought furniture:");
            decimal totalPrice = 0;
            foreach (Furniture furniture in furnitures)
            {
                Console.WriteLine(furniture.Name);
                totalPrice += furniture.Total();
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }



    }
}
