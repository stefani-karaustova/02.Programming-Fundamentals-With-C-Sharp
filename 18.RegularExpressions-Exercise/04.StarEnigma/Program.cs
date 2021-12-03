using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> planetsActions = new Dictionary<string, List<string>>
            {
                ["Attacked"] = new List<string>(),
                ["Destroyed"] = new List<string>(),
            };

            var firstStageDecrypt = new StringBuilder();

            var pattern = @"@(?<planet>[A-Za-z]+)([^@\-!:>])*:(?<population>[0-9]+)([^@\-!:>])*!(?<attack_type>[AD])!([^@\-!:>])*->(?<soldier_count>[0-9]+)";

            for (int i = 0; i < input; i++)
            {
                var message = Console.ReadLine();
                var key = CountCryptoKey(message);
                var firstStage = DecryptFirst(message, key).ToString();

                Match decrypted = Regex.Match(firstStage, pattern);

                if (decrypted.Success)
                {
                    var planetName = decrypted.Groups["planet"].Value;
                    var attackType = decrypted.Groups["attack_type"].Value;

                    if (attackType == "A")
                    {
                        planetsActions["Attacked"].Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        planetsActions["Destroyed"].Add(planetName);
                    }
                }
            }

            foreach (var planet in planetsActions)
            {
                Console.WriteLine($"{planet.Key} planets: {planet.Value.Count}");

                foreach (var planets in planet.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planets}");
                }
            }
        }
        static StringBuilder DecryptFirst(string message, int key)
        {
            StringBuilder firstStageDecrypt = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                firstStageDecrypt.Append((char)(message[i] - key));
            }

            return firstStageDecrypt;
        }
        static int CountCryptoKey(string message)
        {
            var pattern = @"[STARstar]";

            MatchCollection lettersKey = Regex.Matches(message, pattern);

            return lettersKey.Count();
        }
    }
}
