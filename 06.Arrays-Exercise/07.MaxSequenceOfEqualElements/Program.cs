using System;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            var maxSequence = 0;
            var maxIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                var currentElement = arr[i];
                var counter = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currentElement == arr[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (counter > maxSequence)
                {
                    maxSequence = counter;
                    maxIndex = i;
                }
            }

            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write(arr[maxIndex] + " ");
            }
        }
    }
}
