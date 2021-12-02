using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(SubtractSecondAndThirdNumber(firstNumber, secondNumber, thirdNumber));
        }

        private static int SubtractSecondAndThirdNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            var result = SumOfFirstTwoNumbers(firstNumber, secondNumber) - thirdNumber;
            return result;
        }

        private static int SumOfFirstTwoNumbers(int firstNumber, int secondNumber)
        {
            var sum = firstNumber + secondNumber;
            return sum;
        }
    }
}
