using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            string[] firstArray = new string[lines];
            string[] secondArray = new string[lines];

            for (int i = 0; i < lines; i++)
            {
                string[] currentLine = Console.ReadLine()
                    .Split()
                    .ToArray();

                string firstNumber = currentLine[0];
                string secondNumber = currentLine[1];

                if (i % 2 == 0)
                {
                    firstArray[i] = firstNumber;
                    secondArray[i] = secondNumber;
                }
                else
                {
                    firstArray[i] = secondNumber;
                    secondArray[i] = firstNumber;
                }
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
