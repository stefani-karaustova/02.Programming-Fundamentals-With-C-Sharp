using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());
            decimal output = input * 1.31M;

            Console.WriteLine($"{output:f3}");
        }
    }
}
