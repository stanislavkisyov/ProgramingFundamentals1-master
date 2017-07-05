using System;
using System.Collections.Generic;
using System.Linq;
namespace Hands_of_Cards
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var namesCard = new Dictionary<string, List<int>>();

            var line = Console.ReadLine();

            while (line != "JOKER")
            {
                var tokens = line.Split(':');

                var name = tokens[0];


                var cards = tokens[1]
                    .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(CalculateCardValue).ToArray();

                if (!namesCard.ContainsKey(name))
                {
                    namesCard[name] = new List<int>();
                }

                namesCard[name].AddRange(cards);

                line = Console.ReadLine();
            }

            foreach (var nameCard in namesCard)
            {
                var name = nameCard.Key;

                var cards = nameCard.Value;

                var totalSumCards = cards.Distinct().Sum();

                Console.WriteLine($"{name}: {totalSumCards}");
            }
        }

        private static int CalculateCardValue( string card)
        {
            var cardPower = new Dictionary<string, int>();
            cardPower["J"] = 11;
            cardPower["Q"] = 12;
            cardPower["K"] = 13;
            cardPower["A"] = 14;

            for (int i = 2; i <= 10; i++)
            {
                cardPower[i.ToString()] = i;
            }

            var cardType = new Dictionary<string, int>();
            cardType["S"] = 4;
            cardType["H"] = 3;
            cardType["D"] = 2;
            cardType["C"] = 1;

            var power = card.Substring(0, card.Length - 1);
            var type = card.Substring(card.Length - 1);

            var value = cardPower[power] * cardType[type];
            Console.WriteLine();
            return value;
        }
    }
}
