using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var number = input;
            var currentNumber = 0;
            var factorialSum = 0;

            while (number != 0)
            {
                currentNumber = number % 10;
                number /= 10;

                var factorial = 1;

                for (int i = 1; i <= currentNumber; i++)
                {
                    factorial *= i;
                }

                factorialSum += factorial;
            }

            string result = "";

            if (input == factorialSum)
            {
                result = "yes";
            }
            else
            {
                result = "no";
            }

            Console.WriteLine(result);
        }
    }
}
