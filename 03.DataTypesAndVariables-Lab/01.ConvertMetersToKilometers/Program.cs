using System;

namespace _01.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            decimal output = input / 1000.0M;

            Console.WriteLine($"{output:f2}");
        }
    }
}
