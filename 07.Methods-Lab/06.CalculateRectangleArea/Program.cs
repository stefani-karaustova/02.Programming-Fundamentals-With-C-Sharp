using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var area = Area(width, height);
            Console.WriteLine(area);
        }

        static double Area(double width, double height)
        {
            var result = width * height;
            return result;
        }
    }
}
