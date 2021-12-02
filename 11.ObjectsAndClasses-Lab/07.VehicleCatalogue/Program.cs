using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (input != "end")
            {
                string[] line = input.Split("/");

                if (line[0] == "Car")
                {
                    Car car = new Car();

                    car.Brand = line[1];
                    car.Model = line[2];
                    car.HorsePower = int.Parse(line[3]);

                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck();

                    truck.Brand = line[1];
                    truck.Model = line[2];
                    truck.Weight = int.Parse(line[3]);

                    trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            List<Car> sortedCars = cars.OrderBy(cars => cars.Brand).ToList();
            List<Truck> sortedTrucks = trucks.OrderBy(trucks => trucks.Brand).ToList();

            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in sortedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
