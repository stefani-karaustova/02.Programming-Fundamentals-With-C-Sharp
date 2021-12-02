using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            List<People> people = new List<People>();

            while (input != "End")
            {
                string[] line = input.Split();
                var name = line[0];
                var id = line[1];
                var age = int.Parse(line[2]);

                People person = new People(name, id, age);
                people.Add(person);

                input = Console.ReadLine();
            }

            people = people.OrderBy(x => x.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, people));
        }
    }

    class People
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public People(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
