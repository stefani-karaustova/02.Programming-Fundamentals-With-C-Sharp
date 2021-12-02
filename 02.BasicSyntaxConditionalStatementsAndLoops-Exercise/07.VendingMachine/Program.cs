using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var totalCoins = 0.0;

            while (input != "Start")
            {
                var coins = double.Parse(input);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    totalCoins += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                input = Console.ReadLine();
            }

            var moneyLeft = totalCoins;
            input = Console.ReadLine();

            while (input != "End")
            {
                if (input == "Nuts")
                {
                    if (moneyLeft >= 2)
                    {
                        moneyLeft -= 2;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Water")
                {
                    if (moneyLeft >= 0.7)
                    {
                        moneyLeft -= 0.7;
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Crisps")
                {
                    if (moneyLeft >= 1.5)
                    {
                        moneyLeft -= 1.5;
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Soda")
                {
                    if (moneyLeft >= 0.8)
                    {
                        moneyLeft -= 0.8;
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Coke")
                {
                    if (moneyLeft >= 1)
                    {
                        moneyLeft -= 1;
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {moneyLeft:F2}");
        }
    }
}
