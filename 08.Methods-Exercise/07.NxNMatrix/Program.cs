﻿using System;

namespace _07.NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            PrintNumberXNumber(number);
        }

        private static void PrintNumberXNumber(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
            }
        }
    }
}