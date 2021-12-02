using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Console.WriteLine(PrintMiddleChar(input));
        }

        private static string PrintMiddleChar(string input)
        {
            var output = string.Empty;

            if (input.Length % 2 == 0)
            {
                var currentChar = input.Length / 2;
                output = input.Substring(currentChar - 1, 2);
            }

            else
            {
                var currentChar = input.Length / 2;
                output = input.Substring(currentChar, 1);
            }

            return output;
        }
    }
}
