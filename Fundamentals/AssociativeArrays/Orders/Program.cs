using System;
using System.Linq;
using System.Collections.Generic;
/*


 */
namespace Fundamentals
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public Product(string name, decimal price, decimal quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public void Update(decimal price, decimal quantity)
        {
            Price = price;
            Quantity += quantity;
        }

        public override string ToString()
        {
            return $"{Name} -> {Price * Quantity}";
        }
    }

    class Program
    {
        static void Main(string[] arguments)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string product;

            while ((product = Console.ReadLine()) != "buy")
            {
                string[] argument = product.Split();
                string name = argument[0];
                decimal price = decimal.Parse(argument[1]);
                decimal quantity = decimal.Parse(argument[2]);

                Product newProduct = new Product(name, price, quantity);

                if (!products.ContainsKey(newProduct.Name))
                {

                    products.Add(newProduct.Name, newProduct);
                }
                else
                {
                    products[newProduct.Name].Update(newProduct.Price, newProduct.Quantity);
                }

            }

            foreach (KeyValuePair<string, Product> item in products)
            {
                Console.WriteLine(item.Value);
            }
        }

    }
}
