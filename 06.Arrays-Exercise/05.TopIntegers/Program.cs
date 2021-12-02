using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();

            bool isBigger = true;

            for (int i = 0; i < arr.Length; i++)
            {
                var currentNumber = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    var element = arr[j];

                    if (element >= currentNumber)
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    Console.Write(currentNumber + " ");
                }

                isBigger = true;
            }
        }
    }
}
