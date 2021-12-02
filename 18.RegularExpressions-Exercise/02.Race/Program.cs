using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                   .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> infotmation = new Dictionary<string, int>();

            foreach (var name in participants)
            {
                infotmation.Add(name, 0);
            }

            var namePattern = @"[\W\d]";
            var distancePattern = @"[\WA-Za-z]";

            var input = Console.ReadLine();

            while (input != "end of race")
            {
                var name = Regex.Replace(input, namePattern, "");
                var distance = Regex.Replace(input, distancePattern, "");

                var totalDistance = 0;

                foreach (var digit in distance)
                {
                    var currentDigit = int.Parse(digit.ToString());
                    totalDistance += currentDigit;
                }

                if (infotmation.ContainsKey(name))
                {
                    infotmation[name] += totalDistance;
                }

                input = Console.ReadLine();
            }

            var ordered = infotmation.OrderByDescending(x => x.Value)
                .Select(x => x.Key)
                .ToList();

            Console.WriteLine($"1st place: {ordered[0]}");
            Console.WriteLine($"2nd place: {ordered[1]}");
            Console.WriteLine($"3rd place: {ordered[2]}");
        }
    }
}
