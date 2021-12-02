using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            var yield = int.Parse(Console.ReadLine());

            var totalSpice = 0;
            var days = 0;

            while (yield >= 100)
            {
                totalSpice += yield - 26;
                yield -= 10;
                days++;
            }

            if (yield < 100 && days == 0)
            {
                Console.WriteLine(days);
                Console.WriteLine(totalSpice);
            }
            else
            {
                totalSpice -= 26;

                Console.WriteLine(days);
                Console.WriteLine(totalSpice);
            }
        }
    }
}
