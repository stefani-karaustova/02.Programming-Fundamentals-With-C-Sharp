using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToList();

            int[] operation = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var bombNumber = operation[0];
            var power = operation[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];

                if (currentNumber == bombNumber)
                {
                    var startIndex = i - power;
                    var endIndex = i + power;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > numbers.Count - 1)
                    {
                        endIndex = numbers.Count - 1;
                    }

                    var finalIndex = endIndex - startIndex + 1;
                    numbers.RemoveRange(startIndex, finalIndex);

                    i = startIndex - 1;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
