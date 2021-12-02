using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            var lostGames = int.Parse(Console.ReadLine());
            var headsetPrice = double.Parse(Console.ReadLine());
            var mousePrice = double.Parse(Console.ReadLine());
            var keyboardPrice = double.Parse(Console.ReadLine());
            var displayPrice = double.Parse(Console.ReadLine());

            var totalSum = 0.0;

            totalSum += headsetPrice * (lostGames / 2);
            totalSum += mousePrice * (lostGames / 3);
            totalSum += keyboardPrice * (lostGames / 6);
            totalSum += displayPrice * (lostGames / 12);

            Console.WriteLine($"Rage expenses: {totalSum:F2} lv.");
        }
    }
}
