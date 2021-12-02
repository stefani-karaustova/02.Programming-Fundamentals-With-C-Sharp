using System;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @">>([A-Za-z]+)<<(\d+\.?\d+)!(\d+)";
            var regex = new Regex(pattern);

            var furniture = Console.ReadLine();
            var totalMoney = 0.0;

            Console.WriteLine("Bought furniture:");

            while (furniture != "Purchase")
            {
                var match = regex.Match(furniture);

                if (match.Success)
                {
                    var name = match.Groups[1].Value;
                    var price = double.Parse(match.Groups[2].Value);
                    var quantity = int.Parse(match.Groups[3].Value);

                    Console.WriteLine(name);

                    totalMoney += price * quantity;
                }

                furniture = Console.ReadLine();
            }

            Console.WriteLine($"Total money spend: {totalMoney:f2}");
        }
    }
}
