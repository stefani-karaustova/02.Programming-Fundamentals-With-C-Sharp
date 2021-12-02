using System;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            foreach (string element in secondArray)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (element == firstArray[i])
                    {
                        Console.Write($"{element} ");
                        break;
                    }
                }
            }
        }
    }
}
