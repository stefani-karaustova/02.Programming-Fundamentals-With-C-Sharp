using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNumber(firstNumber, secondNumber, thirdNumber));
        }

        public static int SmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            var smallestNumber = int.MinValue;

            if (firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                smallestNumber = firstNumber;
            }

            else if (secondNumber < firstNumber && secondNumber < thirdNumber)
            {
                smallestNumber = secondNumber;
            }

            else if (thirdNumber < firstNumber && thirdNumber < secondNumber)
            {
                smallestNumber = thirdNumber;
            }
            else
            {
                smallestNumber = firstNumber;
            }

            return smallestNumber;
        }
    }
}
