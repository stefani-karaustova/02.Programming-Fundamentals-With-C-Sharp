using System;
using System.Linq;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                string reverseInput = new string(input.Reverse().ToArray());

                Console.WriteLine($"{input} = {reverseInput}");

                input = Console.ReadLine();
            }
        }
    }
}
