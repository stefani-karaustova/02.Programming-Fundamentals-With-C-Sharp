using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstChar = char.Parse(Console.ReadLine());
            var secondChar = char.Parse(Console.ReadLine());

            PrintCharacters(firstChar, secondChar);
        }

        public static void PrintCharacters(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                char one = firstChar;
                firstChar = secondChar;
                secondChar = one;
            }

            for (int i = firstChar + 1; i < secondChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
