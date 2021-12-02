using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());
            MathPower(number, power);
        }

        static double MathPower(double number, int power)
        {
            var result = Math.Pow(number, power);
            Console.WriteLine(result);
            return result;
        }
    }
}
