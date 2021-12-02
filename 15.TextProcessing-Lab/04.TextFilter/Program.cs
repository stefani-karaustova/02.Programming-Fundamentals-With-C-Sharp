using System;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                   .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                var replacedWord = new string('*', word.Length);

                text = text.Replace(word, replacedWord);
            }

            Console.WriteLine(text);
        }
    }
}
