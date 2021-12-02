using System;
using System.Linq;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var usernames = Console.ReadLine().Split(", ");

            for (int i = 0; i < usernames.Length; i++)
            {
                var currentUsername = usernames[i];

                if (IsValid(currentUsername))
                {
                    Console.WriteLine(currentUsername);
                }
            }
        }

        public static bool IsValid(string currentUsername)
        {
            return currentUsername.Length >= 3 &&
                currentUsername.Length <= 16 &&
                currentUsername.All(c => char.IsLetterOrDigit(c)) ||
                currentUsername.Contains("-") ||
                currentUsername.Contains("_");
        }
    }
}
