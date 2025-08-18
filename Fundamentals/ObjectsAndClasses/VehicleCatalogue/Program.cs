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
    public class Vehicle
    {
        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public Vehicle(string typeOfVehicles, string model, string color, double horsePower)
        {
            TypeOfVehicle = typeOfVehicles;
            Model = model;
            Color = color;
            HorsePower = horsePower;

        }

        public override string ToString()
        {
            return $"Type: {TypeOfVehicle}\n" +
                $"Model: {Model}\n" +
                $"Color: {Color}\n" +
                $"Horsepower: {HorsePower}";
        }

    }

    class Program
    {
        static void Main(string[] arguments)
        {
            string input;
            List<Vehicle> catalogue = new List<Vehicle>();
            string typeOfVehicle;
            string model;
            string color;
            double horsePower;

            while ((input = Console.ReadLine()) != "End")
            {
                if (catalogue.Count > 50)
                {
                    break;
                }
                string[] array = input.Split().ToArray();
                typeOfVehicle = array[0];
                model = array[1];
                color = array[2];
                horsePower = double.Parse(array[3]);
                Vehicle vehicle = new Vehicle(typeOfVehicle, model, color, horsePower);
                if (vehicle.TypeOfVehicle == "car")
                {
                    vehicle.TypeOfVehicle = "Car";
                }
                else
                {
                    vehicle.TypeOfVehicle = "Truck";
                }
                catalogue.Add(vehicle);


            }
            string command;
            List<double> carHP = new List<double>();
            List<double> truckHP = new List<double>();
            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in catalogue)
                {
                    if (vehicle.Model == command)
                    {
                        Console.WriteLine(vehicle.ToString());
                    }

                }
            }
            double averageHP = catalogue.Where(vehicle => vehicle.TypeOfVehicle == "Car")
                .Select(vehicle => vehicle.HorsePower)
                .DefaultIfEmpty()
                .Average();

            Console.WriteLine($"Cars have average horsepower of: {averageHP:F2}.");
            averageHP = catalogue.Where(vehicle => vehicle.TypeOfVehicle == "Truck")
                .Select(vehicle => vehicle.HorsePower)
                .DefaultIfEmpty()
                .Average();
            Console.WriteLine($"Trucks have average horsepower of: {averageHP:F2}.");

        }

    }
}
