using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            Price(order, quantity);
        }

        static void Price(string order, int quantity)
        {
            var price = 0.0;

            switch (order)
            {
                case "coffee":
                    price = 1.5 * quantity;
                    break;
                case "water":
                    price = 1 * quantity;
                    break;
                case "coke":
                    price = 1.4 * quantity;
                    break;
                case "snacks":
                    price = 2 * quantity;
                    break;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
