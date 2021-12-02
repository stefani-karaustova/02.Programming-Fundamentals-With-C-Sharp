using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine();

            var pattern = @"\+359([- ])2\1[\d]{3}\1[\d]{4}\b";
            var matches = Regex.Matches(phoneNumbers, pattern);

            var matchedPhones = matches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
