using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            var demons = new List<Demon>();

            var numbersPattern = @"[-+]?[0-9]+\.?[0-9]*";

            var numbersRegex = new Regex(numbersPattern);

            var allDemons = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var demon in allDemons)
            {
                var filter = "0123456789+-*/.";
                var health = demon.Where(x => !filter.Contains(x)).Sum(x => x);
                var damage = Damage(numbersRegex, demon);

                demons.Add(new Demon { Name = demon, Health = health, Damage = damage });
            }

            foreach (var demon in demons.OrderBy(d => d.Name))
            {
                Console.WriteLine(demon);
            }
        }

        private static double Damage(Regex numbersRegex, string demon)
        {
            MatchCollection matches = numbersRegex.Matches(demon);

            var currentDamage = 0.0;

            foreach (Match match in matches)
            {
                currentDamage += double.Parse(match.Value);
            }

            foreach (var item in demon)
            {
                if (item == '*')
                {
                    currentDamage *= 2.0;
                }
                else if (item == '/')
                {
                    currentDamage /= 2.0;
                }
            }

            return currentDamage;
        }
    }

    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Health} health, {Damage:f2} damage";
        }
    }
}
