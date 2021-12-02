using System;
using System.Text;

namespace _05.DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var digits = new StringBuilder();
            var letters = new StringBuilder();
            var others = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                var character = text[i];

                if (char.IsDigit(character))
                {
                    digits.Append(character);
                }

                else if (char.IsLetter(character))
                {
                    letters.Append(character);
                }

                else
                {
                    others.Append(character);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
