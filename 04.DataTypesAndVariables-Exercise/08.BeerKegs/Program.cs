using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var biggestKeg = string.Empty;
            var currentBiggest = 0.0;

            for (int i = 0; i < n; i++)
            {
                var model = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());

                var volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > currentBiggest)
                {
                    biggestKeg = model;
                    currentBiggest = volume;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
