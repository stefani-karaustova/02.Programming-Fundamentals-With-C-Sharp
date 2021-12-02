using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            Triangle(input);
        }

        static void SingleLine(int startNumber, int endNumber)
        {
            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void Triangle(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                SingleLine(1, i);
            }

            for (int j = end - 1; j >= 1; j--)
            {
                SingleLine(1, j);
            }
        }
    }
}
