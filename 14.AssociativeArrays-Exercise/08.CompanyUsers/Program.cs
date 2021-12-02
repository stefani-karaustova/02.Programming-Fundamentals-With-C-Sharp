using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Dictionary<string, List<string>> pairs = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] command = input.Split(" -> ");
                var companyName = command[0];
                var employeeId = command[1];

                if (!pairs.ContainsKey(companyName) && !pairs.ContainsKey(employeeId))
                {
                    pairs.Add(companyName, new List<string>());
                    pairs[companyName].Add(employeeId);
                }
                else
                {
                    if (!pairs[companyName].Contains(employeeId))
                    {
                        pairs[companyName].Add(employeeId);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var pair in pairs.OrderBy(p => p.Key))
            {
                Console.WriteLine($"{pair.Key}");

                foreach (var item in pair.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
