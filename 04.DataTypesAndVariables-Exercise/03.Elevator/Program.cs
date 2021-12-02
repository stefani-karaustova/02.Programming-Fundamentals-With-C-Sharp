using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());

            var courses = 0;

            while (numberOfPeople > 0)
            {
                numberOfPeople -= capacity;
                courses++;
            }

            Console.WriteLine(courses);
        }
    }
}
