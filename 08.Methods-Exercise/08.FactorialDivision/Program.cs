using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            var firstFactorial = FactorialOfFirstNumber(firstNumber);
            var secondFactorial = FactorialOfSecondNumber(secondNumber);
            var result = firstFactorial / secondFactorial;

            Console.WriteLine($"{result:f2}");
        }

        public static double FactorialOfFirstNumber(int firstNumber)
        {
            var factorialOne = 1.0;

            while (firstNumber != 1)
            {
                factorialOne = factorialOne * firstNumber;
                firstNumber = firstNumber - 1;
            }

            return factorialOne;
        }

        public static double FactorialOfSecondNumber(int secondNumber)
        {
            var factorialTwo = 1.0;

            while (secondNumber != 1)
            {
                factorialTwo = factorialTwo * secondNumber;
                secondNumber = secondNumber - 1;
            }

            return factorialTwo;
        }
    }
}
