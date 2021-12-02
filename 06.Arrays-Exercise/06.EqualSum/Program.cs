using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();

            bool isFound = false;

            for (int i = 0; i < arr.Length; i++)
            {
                var rightSum = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    rightSum += arr[j];
                }

                var leftSum = 0;

                for (int k = i - 1; k >= 0; k--)
                {
                    leftSum += arr[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
