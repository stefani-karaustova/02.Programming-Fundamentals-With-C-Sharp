using System;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine()
                      .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var sum = 0.0;
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < sequence.Length; i++)
            {
                var current = sequence[i];

                var firstLetter = current[0];
                var lastLetter = current[current.Length - 1];
                var number = double.Parse(current.Substring(1, current.Length - 2));

                var indexOfFirstElement = alphabet.IndexOf(char.ToUpper(firstLetter));
                var indexOfLastElement = alphabet.IndexOf(char.ToUpper(lastLetter));

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    number = number / (indexOfFirstElement + 1);
                }
                else
                {
                    number = number * (indexOfFirstElement + 1);
                }

                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    number = number - (indexOfLastElement + 1);
                }
                else
                {
                    number = number + (indexOfLastElement + 1);
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
