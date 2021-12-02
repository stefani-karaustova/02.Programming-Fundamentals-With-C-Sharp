using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculation = Console.ReadLine();
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            switch (calculation)
            {
                case "add":
                    Add(firstNumber, secondNumber);
                    break;
                case "multiply":
                    Multiply(firstNumber, secondNumber);
                    break;
                case "subtract":
                    Subtract(firstNumber, secondNumber);
                    break;
                case "divide":
                    Divide(firstNumber, secondNumber);
                    break;
            }
        }

        static void Add(int firstNumber, int secondNumber)
        {
            var result = firstNumber + secondNumber;
            Console.WriteLine(result);
        }
        static void Multiply(int firstNumber, int secondNumber)
        {
            var result = firstNumber * secondNumber;
            Console.WriteLine(result);
        }
        static void Subtract(int firstNumber, int secondNumber)
        {
            var result = firstNumber - secondNumber;
            Console.WriteLine(result);
        }
        static void Divide(int firstNumber, int secondNumber)
        {
            var result = firstNumber / secondNumber;
            Console.WriteLine(result);
        }
    }
}
