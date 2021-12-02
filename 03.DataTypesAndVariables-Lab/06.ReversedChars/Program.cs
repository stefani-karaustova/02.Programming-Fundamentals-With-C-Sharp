using System;

namespace _06.ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCharacter = char.Parse(Console.ReadLine());
            var secondCharacter = char.Parse(Console.ReadLine());
            var thirdCharacter = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdCharacter} {secondCharacter} {firstCharacter}");
        }
    }
}
