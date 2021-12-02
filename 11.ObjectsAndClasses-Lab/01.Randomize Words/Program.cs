using System;

namespace _01.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random rnd = new Random();

            for (int i = 0; i < words.Length - 1; i++)
            {
                var index = rnd.Next(0, words.Length);
                var word = words[i];
                words[i] = words[index];
                words[index] = word;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
