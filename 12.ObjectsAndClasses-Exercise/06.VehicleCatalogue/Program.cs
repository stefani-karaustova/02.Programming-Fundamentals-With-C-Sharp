using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            List<Vehicle> vehicles = new List<Vehicle>();

            while (input != "End")
            {
                var line = input.Split();

                var vehicleType = line[0].ToLower();
                var model = line[1];
                var color = line[2].ToLower();
                var horsepower = double.Parse(line[3]);

                Vehicle vehicle = new Vehicle(vehicleType, model, color, horsepower);
                vehicles.Add(vehicle);

                input = Console.ReadLine();
            }

            var command = Console.ReadLine();

            while (command != "Close the Catalogue")
            {
                var model = command;
                Vehicle printCar = vehicles.First(x => x.Model == model);

                Console.WriteLine(printCar);

                command = Console.ReadLine();
            }

            List<Vehicle> cars = vehicles.Where(x => x.Type == "car").ToList();
            List<Vehicle> trucks = vehicles.Where(x => x.Type == "truck").ToList();

            var totalForCars = cars.Sum(x => x.Horsepower);
            var totalForTrucks = trucks.Sum(x => x.Horsepower);

            var averageForCars = 0.00;
            var averageForTrucks = 0.00;

            if (cars.Count > 0)
            {
                averageForCars = totalForCars / cars.Count;
            }

            if (trucks.Count > 0)
            {
                averageForTrucks = totalForTrucks / trucks.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {averageForCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageForTrucks:f2}.");
        }
    }

    class Vehicle
    {
        public Vehicle(string vehicleType, string model, string color, double horsepower)
        {
            Type = vehicleType;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"Type: {(Type == "car" ? "Car" : "Truck")}");
            output.AppendLine($"Model: {Model}");
            output.AppendLine($"Color: {Color}");
            output.AppendLine($"Horsepower: {Horsepower}");

            return output.ToString().TrimEnd();
        }
    }
}
