using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine();

            var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            Regex regex = new Regex(pattern);

            MatchCollection matchedNames = regex.Matches(names);

            Console.WriteLine(string.Join(" ", matchedNames));
        }
    }
}
