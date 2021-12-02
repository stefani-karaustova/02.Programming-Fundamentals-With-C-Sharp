using System;

namespace _05.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var finish = int.Parse(Console.ReadLine());

            for (int i = start; i <= finish; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
