namespace OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;
/*
truck Man red 200
truck Mercedes blue 300
car Ford green 120
car Ferrari red 550
car Lamborghini orange 570
End
Ferrari
Ford
Man
Close the Catalogue

 */
namespace Fundamentals
{
    public class People
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public People(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;

        }

        public string Display()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }

    }

    class Program
    {
        static void Main(string[] arguments)
        {
            string input;
            List<People> list = new List<People>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] array = input.Split().ToArray();
                People person = new People(array[0], array[1], int.Parse(array[2]));
                list.Add(person);
            }
            List<People> list2 = new List<People>();
            list2 = list.OrderBy(x => x.Age).ToList();

            foreach (People ppl in list2)
            {
                Console.WriteLine(ppl.Display());
            }

        }

    }
}
