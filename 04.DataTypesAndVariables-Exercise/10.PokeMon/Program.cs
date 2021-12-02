using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokePower = int.Parse(Console.ReadLine());
            var distance = int.Parse(Console.ReadLine());
            var exhaustionFactor = int.Parse(Console.ReadLine());

            var targetsCount = 0;
            var currentPower = pokePower * 0.5;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                targetsCount++;

                if (pokePower == currentPower && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetsCount);
        }
    }
}
