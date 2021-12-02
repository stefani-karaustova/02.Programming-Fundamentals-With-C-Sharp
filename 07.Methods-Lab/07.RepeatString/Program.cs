using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            RepeatString(text, count);
        }

        static string RepeatString(string text, int count)
        {
            var result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result = text;
                Console.Write(result);
            }

            return result;
        }
    }
}
