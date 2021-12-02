using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();

            var sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int nextNumber = arr[j];

                    if (currentNumber + nextNumber == sum)
                    {
                        Console.WriteLine($"{currentNumber} {nextNumber}");
                    }
                }
            }
        }
    }
}
