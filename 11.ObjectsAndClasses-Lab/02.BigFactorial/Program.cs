﻿using System;
using System.Numerics;

namespace _02.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
