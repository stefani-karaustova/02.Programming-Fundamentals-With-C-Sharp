using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var operation = Console.ReadLine();
            var secontNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculation(firstNumber, operation, secontNumber));
        }

        private static double Calculation(int firstNumber, string operation, int secondNumber)
        {
            var result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }

            return result;
        }
    }
}
