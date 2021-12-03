using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-][A-Za-z]+)+))(\b|(?=\s))";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            if (regex.IsMatch(input))
            {
                foreach (Match email in matches)
                {
                    Console.WriteLine(email);
                }
            }
        }
    }
}
