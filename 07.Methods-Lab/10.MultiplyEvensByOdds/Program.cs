using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Math.Abs(int.Parse(Console.ReadLine()));

            var result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int multiple)
        {
            var result = GetSumOfEvenDigits(multiple) * GetSumOfOddDigits(multiple);
            return result;
        }

        static int GetSumOfEvenDigits(int even)
        {
            var evenSum = 0;

            while (even > 0)
            {
                var next = even % 10;
                even /= 10;

                if (next % 2 == 0)
                {
                    evenSum += next;
                }
            }

            return evenSum;
        }

        static int GetSumOfOddDigits(int odd)
        {
            var oddSum = 0;

            while (odd > 0)
            {
                var next = odd % 10;
                odd /= 10;
                if (next % 2 != 0)
                {
                    oddSum += next;
                }
            }

            return oddSum;
        }
    }
}
