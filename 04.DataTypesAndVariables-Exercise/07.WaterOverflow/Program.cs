using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacity = 255;
            var litersInTank = 0;

            var lines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                var water = int.Parse(Console.ReadLine());

                if (water > capacity || litersInTank + water > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                litersInTank += water;
            }

            Console.WriteLine(litersInTank);
        }
    }
}
