using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            var length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            var width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            var height = double.Parse(Console.ReadLine());

            var area = length * width;
            var volume = area / 3 * height;

            Console.Write($"Pyramid Volume: {volume:f2}");
        }
    }
}
