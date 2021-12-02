using System;
using System.Linq;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = Console.ReadLine().TrimStart('0');
            var secondNumber = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();
            var temp = 0;

            if (secondNumber == 0 || firstNumber == "")
            {
                Console.WriteLine(0);
                return;
            }

            foreach (var digit in firstNumber.Reverse())
            {
                var currentDigit = int.Parse(digit.ToString());
                var result = currentDigit * secondNumber + temp;

                var lastDigit = result % 10;
                temp = result / 10;

                sb.Insert(0, lastDigit);
            }

            if (temp > 0)
            {
                sb.Insert(0, temp);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
