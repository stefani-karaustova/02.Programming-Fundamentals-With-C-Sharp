using System;

namespace _09.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var sum = 0;

            if (number >= 1 && number <= 100)
            {
                for (int i = 1; i < number * 2; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                        sum += i;
                    }
                }
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
