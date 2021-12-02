using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var currentNumber = (int)Char.GetNumericValue(input[i]);
                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
