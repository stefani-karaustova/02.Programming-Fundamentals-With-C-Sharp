using System;

namespace _04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            var totalSum = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                var input = char.Parse(Console.ReadLine());
                totalSum += input;
            }

            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
