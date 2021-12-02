using System;

namespace _04.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCenturies = int.Parse(Console.ReadLine());

            var years = numberOfCenturies * 100;
            var days = (int)(years * 365.2422);
            var hours = days * 24;
            var minutes = hours * 60;

            Console.WriteLine($"{numberOfCenturies} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
