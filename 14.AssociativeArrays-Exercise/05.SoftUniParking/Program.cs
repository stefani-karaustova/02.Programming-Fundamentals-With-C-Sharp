using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCommands = int.Parse(Console.ReadLine());

            Dictionary<string, string> registered = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split();
                var command = input[0];
                var username = input[1];

                if (command == "register")
                {
                    var licensePlateNumber = input[2];

                    if (!registered.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        registered.Add(username, licensePlateNumber);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else
                {
                    if (!registered.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        registered.Remove(username);
                    }
                }
            }

            foreach (var user in registered)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
