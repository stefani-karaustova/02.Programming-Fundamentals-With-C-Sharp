using System;
using System.Collections.Generic;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < commands; i++)
            {
                string[] message = Console.ReadLine().Split();

                if (message.Length > 3)
                {
                    if (guests.Contains(message[0]))
                    {
                        guests.Remove(message[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{message[0]} is not in the list!");
                    }
                }
                else
                {
                    if (!guests.Contains(message[0]))
                    {
                        guests.Add(message[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{message[0]} is already in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, guests));
        }
    }
}
