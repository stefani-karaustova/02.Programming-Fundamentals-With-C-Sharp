﻿using System;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            var rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                var firstElement = arr[0];

                for (int j = 1; j < arr.Length; j++)
                {
                    var currentElement = arr[j];
                    arr[j - 1] = currentElement;
                }
                arr[arr.Length - 1] = firstElement;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
