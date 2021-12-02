using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            Console.WriteLine(CountOfVowels(input));
        }

        public static int CountOfVowels(string input)
        {
            var count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var currenChar = input[i];

                switch (currenChar)
                {
                    case 'a':
                        count++;
                        break;
                    case 'e':
                        count++;
                        break;
                    case 'o':
                        count++;
                        break;
                    case 'i':
                        count++;
                        break;
                    case 'u':
                        count++;
                        break;
                }
            }

            return count;
        }
    }
}
