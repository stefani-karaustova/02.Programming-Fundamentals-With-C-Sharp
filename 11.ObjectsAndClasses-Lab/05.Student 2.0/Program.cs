using System;
using System.Collections.Generic;

namespace _05.Student_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            var line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split();

                var firstName = tokens[0];
                var lastName = tokens[1];
                var age = int.Parse(tokens[2]);
                var homeTown = tokens[3];

                if (StudentExists(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown
                    };

                    students.Add(student);
                }

                line = Console.ReadLine();
            }

            var filter = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == filter)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        public static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existindStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existindStudent = student;
                }
            }

            return existindStudent;
        }

        public static bool StudentExists(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
}
