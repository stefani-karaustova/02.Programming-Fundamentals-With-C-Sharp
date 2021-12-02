using System;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();

            int[] sortedNumers = numbers.OrderByDescending(n => n).ToArray();

            var count = sortedNumers.Length >= 3 ? 3 : numbers.Length;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{sortedNumers[i]} ");
            }
        }
    }
}
