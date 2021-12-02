using System;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            foreach (var character in text)
            {
                var encryptedText = (char)(character + 3);
                Console.Write(encryptedText);
            }
        }
    }
}
