using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                   .Split('|')
                   .ToList();

            items.Reverse();

            List<string> result = new List<string>();

            foreach (var item in items)
            {
                string[] numbers = item
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach (var number in numbers)
                {
                    result.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
