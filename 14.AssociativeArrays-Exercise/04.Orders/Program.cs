using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Dictionary<string, List<double>> output = new Dictionary<string, List<double>>();

            while (input != "buy")
            {
                string[] product = input.Split();
                var name = product[0];
                var price = double.Parse(product[1]);
                var quantity = double.Parse(product[2]);

                if (!output.ContainsKey(name))
                {
                    List<double> priceAndQuantity = new List<double>
                    {
                        price,
                        quantity
                    };
                    output.Add(name, priceAndQuantity);
                }
                else
                {
                    output[name][0] = price;
                    output[name][1] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var item in output)
            {
                var totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}
