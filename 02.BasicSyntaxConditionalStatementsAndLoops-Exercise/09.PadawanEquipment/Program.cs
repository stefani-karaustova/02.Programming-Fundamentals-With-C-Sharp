using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var priceOfLightsabers = double.Parse(Console.ReadLine());
            var priceOfRobes = double.Parse(Console.ReadLine());
            var priceOfBelts = double.Parse(Console.ReadLine());

            var freeBelts = students / 6;

            var totalLightsabers = priceOfLightsabers * Math.Ceiling(students + (students * 0.1));
            var totalRobes = students * priceOfRobes;
            var totalBelts = (students - freeBelts) * priceOfBelts;

            var totalSum = totalBelts + totalLightsabers + totalRobes;

            if (totalSum <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
            }
            else
            {
                var neededMoney = Math.Abs(totalSum - money);
                Console.WriteLine($"Ivan Cho will need {neededMoney:F2}lv more.");
            }
        }
    }
}
