using System;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            var counter = 0;
            var bestCount = 0;
            var bestIndex = 0;
            var bestSum = 0;
            var bestCounter = 0;
            var bestSequence = "";


            while (input != "Clone them!")
            {
                string sequence = input.Replace("!", "");
                string[] dnaParts = sequence.Split("0", StringSplitOptions.RemoveEmptyEntries);

                var count = 0;
                var currentSum = 0;
                var bestSubSequence = string.Empty;
                counter++;

                foreach (string part in dnaParts)
                {
                    if (part.Length > count)
                    {
                        count = part.Length;
                        bestSubSequence = part;
                    }
                    currentSum += part.Length;
                }

                var currentIndex = sequence.IndexOf(bestSubSequence);

                if (count > bestCount ||
                    (count == bestCount && currentIndex < bestIndex) ||
                    (count == bestCount && currentIndex == bestIndex && currentSum > bestSum) ||
                    counter == 1)
                {
                    bestCount = count;
                    bestSequence = sequence;
                    bestSum = currentSum;
                    bestIndex = currentIndex;
                    bestCounter = counter;
                }

                input = Console.ReadLine();
            }

            char[] dnaSequence = bestSequence.ToCharArray();

            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", dnaSequence));
        }
    }
}
