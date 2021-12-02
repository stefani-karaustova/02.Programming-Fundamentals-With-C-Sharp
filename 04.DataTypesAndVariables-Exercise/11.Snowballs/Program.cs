using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfSnowballs = int.Parse(Console.ReadLine());

            var highestSnowballSnow = 0;
            var highestSnowballTime = 0;
            BigInteger snowballValue = 0;
            var highestSnowballQuality = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                var snowballSnow = int.Parse(Console.ReadLine());
                var snowballTime = int.Parse(Console.ReadLine());
                var snowballQuality = int.Parse(Console.ReadLine());

                var value = snowballSnow / snowballTime;
                BigInteger currentSnowballValue = BigInteger.Pow(value, snowballQuality);

                if (currentSnowballValue >= snowballValue)
                {
                    snowballValue = currentSnowballValue;
                    highestSnowballSnow = snowballSnow;
                    highestSnowballTime = snowballTime;
                    highestSnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{highestSnowballSnow} : {highestSnowballTime} = {snowballValue} ({highestSnowballQuality})");
        }
    }
}
