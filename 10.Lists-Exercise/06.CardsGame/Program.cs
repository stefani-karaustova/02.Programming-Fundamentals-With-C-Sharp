using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToList();

            List<int> secondDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (firstDeck.Count != 0 && secondDeck.Count != 0)
            {
                var cardFromFirstDeck = firstDeck[0];
                var cardFromSecondDeck = secondDeck[0];

                if (cardFromFirstDeck > cardFromSecondDeck)
                {
                    firstDeck.Add(cardFromFirstDeck);
                    firstDeck.Add(cardFromSecondDeck);
                }

                else if (cardFromFirstDeck < cardFromSecondDeck)
                {
                    secondDeck.Add(cardFromSecondDeck);
                    secondDeck.Add(cardFromFirstDeck);
                }

                firstDeck.RemoveAt(0);
                secondDeck.RemoveAt(0);
            }

            if (firstDeck.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
            }
        }
    }
}
