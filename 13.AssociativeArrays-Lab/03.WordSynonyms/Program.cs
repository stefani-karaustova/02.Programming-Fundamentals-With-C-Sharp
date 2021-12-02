using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();
                var synonym = Console.ReadLine();

                if (dictionary.ContainsKey(word))
                {
                    dictionary[word].Add(synonym);
                }
                else
                {
                    dictionary.Add(word, new List<string>() { synonym });
                }
            }

            foreach (var synonym in dictionary)
            {
                Console.WriteLine($"{synonym.Key} - { string.Join(", ", synonym.Value) }");
            }
        }
    }
}
