using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var dayOfWeek = Console.ReadLine();

            var price = 0.0;
            var totalPrice = 0.0;

            if (type == "Students")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        price = 8.45;
                        break;
                    case "Saturday":
                        price = 9.8;
                        break;
                    case "Sunday":
                        price = 10.46;
                        break;
                }

                totalPrice = people * price;

                if (people >= 30)
                {
                    totalPrice = totalPrice - totalPrice * 0.15;
                }
            }
            else if (type == "Business")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        price = 10.9;
                        break;
                    case "Saturday":
                        price = 15.6;
                        break;
                    case "Sunday":
                        price = 16;
                        break;
                }

                totalPrice = people * price;

                if (people >= 100)
                {
                    totalPrice = (people - 10) * price;
                }
            }
            else if (type == "Regular")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        price = 15;
                        break;
                    case "Saturday":
                        price = 20;
                        break;
                    case "Sunday":
                        price = 22.5;
                        break;
                }

                totalPrice = people * price;

                if (people >= 10 && people <= 20)
                {
                    totalPrice = totalPrice - totalPrice * 0.05;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
