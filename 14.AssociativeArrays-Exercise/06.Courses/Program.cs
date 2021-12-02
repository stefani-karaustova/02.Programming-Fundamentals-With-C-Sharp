using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" : ");

            Dictionary<string, List<string>> registered = new Dictionary<string, List<string>>();

            while (input[0] != "end")
            {
                var course = input[0];
                var student = input[1];

                if (!registered.ContainsKey(course))
                {
                    registered.Add(course, new List<string>());
                }

                registered[course].Add(student);

                input = Console.ReadLine().Split(" : ");
            }

            foreach (var course in registered.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var item in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
