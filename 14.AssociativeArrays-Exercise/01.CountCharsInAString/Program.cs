using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = Console.ReadLine().ToCharArray();

            Dictionary<char, int> occurences = new Dictionary<char, int>();

            foreach (var letter in letters)
            {
                if (letter != ' ')
                {
                    if (!occurences.ContainsKey(letter))
                    {
                        occurences.Add(letter, 0);
                    }
                    occurences[letter]++;
                }
            }

            foreach (var item in occurences)
            {
                var currentKey = item.Key;
                var currentValue = item.Value;

                Console.WriteLine($"{currentKey} -> {currentValue}");
            }
        }
    }
}
