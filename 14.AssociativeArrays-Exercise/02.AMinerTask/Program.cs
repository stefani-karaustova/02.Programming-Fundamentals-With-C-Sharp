using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Dictionary<string, int> sequence = new Dictionary<string, int>();

            while (input != "stop")
            {
                var quantity = int.Parse(Console.ReadLine());

                if (!sequence.ContainsKey(input))
                {
                    sequence.Add(input, 0);
                }
                sequence[input] += quantity;

                input = Console.ReadLine();
            }

            foreach (var item in sequence)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
