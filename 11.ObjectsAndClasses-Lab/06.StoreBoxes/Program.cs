using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            decimal boxPrice = 0;

            List<Box> itemBoxes = new List<Box>();

            while (input != "end")
            {
                string[] line = input.Split();

                var serialNumber = line[0];
                var itemName = line[1];
                var itemQuantity = int.Parse(line[2]);
                var itemPrice = decimal.Parse(line[3]);

                boxPrice = itemQuantity * itemPrice;

                Box box = new Box();

                box.SerialNumber = serialNumber;
                box.ItemName = itemName;
                box.ItemQuantity = itemQuantity;
                box.PriceForABox = itemPrice;
                box.TotalPrice = itemPrice * itemQuantity;

                itemBoxes.Add(box);

                input = Console.ReadLine();
            }

            List<Box> sorted = itemBoxes.OrderBy(boxes => boxes.TotalPrice).ToList();

            sorted.Reverse();

            foreach (Box box in sorted)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.ItemName} - ${box.PriceForABox:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.TotalPrice:f2}");
            }
        }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
