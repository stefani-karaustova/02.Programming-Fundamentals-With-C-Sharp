using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"%([A-Z][a-z]+)%[^|$%.]*<(\w+)>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+\.?\d*)\$";
            var regex = new Regex(pattern);

            var input = Console.ReadLine();

            var totalIncome = 0.0;

            while (input != "end of shift")
            {
                var match = regex.Match(input);

                if (match.Success)
                {
                    var customer = match.Groups[1].Value;
                    var product = match.Groups[2].Value;
                    var quantity = int.Parse(match.Groups[3].Value);
                    var price = double.Parse(match.Groups[4].Value);

                    var sum = price * quantity;
                    totalIncome += sum;

                    Console.WriteLine($"{customer}: {product} - {sum:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
