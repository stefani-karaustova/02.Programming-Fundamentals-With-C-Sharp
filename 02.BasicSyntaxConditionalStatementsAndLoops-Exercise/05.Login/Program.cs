using System;
using System.Linq;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();

            var password = Console.ReadLine();
            var correctPassword = new string(username.Reverse().ToArray());
            var counter = 1;

            while (password != correctPassword)
            {
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    Environment.Exit(0);
                }
                if (password == correctPassword)
                {
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");

                password = Console.ReadLine();

                counter++;
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
