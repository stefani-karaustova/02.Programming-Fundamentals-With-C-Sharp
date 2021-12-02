using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var firstWord = input[0];
            var secondWord = input[1];

            var longerWord = firstWord;
            var shorterWord = secondWord;

            if (firstWord.Length < secondWord.Length)
            {
                longerWord = secondWord;
                shorterWord = firstWord;
            }

            var output = Multiplier(longerWord, shorterWord);
            Console.WriteLine(output);
        }

        public static int Multiplier(string longerWord, string shorterWord)
        {
            var sum = 0;

            for (int i = 0; i < shorterWord.Length; i++)
            {
                var multiply = longerWord[i] * shorterWord[i];
                sum += multiply;
            }

            for (int i = shorterWord.Length; i < longerWord.Length; i++)
            {
                sum += longerWord[i];
            }

            return sum;
        }
    }
}
