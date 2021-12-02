using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();

            var input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] command = input.Split(" | ").ToArray();
                    var forceSide = command[0];
                    var forceUser = command[1];

                    if (!forceBook.Any(x => x.Value.Contains(forceUser)))
                    {
                        if (!forceBook.ContainsKey(forceSide))
                        {
                            forceBook[forceSide] = new List<string>();
                        }

                        forceBook[forceSide].Add(forceUser);
                    }
                }

                else
                {
                    string[] command = input.Split(" -> ").ToArray();
                    var forceUser = command[0];
                    var forceSide = command[1];

                    foreach (var item in forceBook)
                    {
                        if (item.Value.Contains(forceUser))
                        {
                            item.Value.Remove(forceUser);
                        }
                    }

                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook[forceSide] = new List<string>();
                    }

                    forceBook[forceSide].Add(forceUser);

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }

                input = Console.ReadLine();
            }

            forceBook = forceBook
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var side in forceBook)
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                foreach (var user in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
