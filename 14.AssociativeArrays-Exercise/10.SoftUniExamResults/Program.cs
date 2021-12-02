using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] command = input.Split("-");
                var username = command[0];

                if (command.Length > 2)
                {
                    var language = command[1];
                    var points = int.Parse(command[2]);

                    if (!results.ContainsKey(username))
                    {
                        results.Add(username, points);
                    }
                    else
                    {
                        if (results[username] < points)
                        {
                            results[username] = points;
                        }
                    }

                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }

                    submissions[language]++;
                }
                else
                {
                    results.Remove(username);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");

            foreach (var result in results
                .OrderByDescending(r => r.Value)
                .ThenBy(r => r.Key))
            {
                Console.WriteLine($"{result.Key} | {result.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var submission in submissions
                .OrderByDescending(s => s.Value)
                .ThenBy(s => s.Key))
            {
                Console.WriteLine($"{submission.Key} - {submission.Value}");
            }
        }
    }
}
