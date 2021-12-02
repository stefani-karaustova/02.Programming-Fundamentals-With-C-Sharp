using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var firstValue = Console.ReadLine();
            var secondValue = Console.ReadLine();

            Console.WriteLine(GreaterValue(type, firstValue, secondValue));
        }

        private static string GreaterValue(string type, string firstValue, string secondValue)
        {
            var result1 = 0;
            var result2 = 0;

            if (type == "int")
            {
                result1 = int.Parse(firstValue);
                result2 = int.Parse(secondValue);
            }
            else if (type == "char")
            {
                result1 = char.Parse(firstValue);
                result2 = char.Parse(secondValue);
            }
            else if (type == "string")
            {
                int comparison = firstValue.CompareTo(secondValue);

                if (comparison > 0)
                {
                    return firstValue;
                }
                else
                {
                    return secondValue;
                }
            }

            if (result1 > result2)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
    }
}
