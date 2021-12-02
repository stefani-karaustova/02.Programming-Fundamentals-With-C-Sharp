using System;

namespace _12.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            while (input != 0)
            {
                if (input % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                }

                if (input % 2 == 0)
                {
                    var number = Math.Abs(input);
                    Console.WriteLine($"The number is: {number}");
                    break;
                }

                input = int.Parse(Console.ReadLine());
            }
        }
    }
}
