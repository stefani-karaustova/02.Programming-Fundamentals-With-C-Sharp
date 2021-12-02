﻿using System;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var wagons = int.Parse(Console.ReadLine());
            int[] people = new int[wagons];

            for (int i = 0; i < wagons; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", people));
            Console.WriteLine(people.Sum());
        }
    }
}
