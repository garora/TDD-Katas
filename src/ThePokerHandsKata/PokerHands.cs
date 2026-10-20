// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;

namespace TDD_Katas_project.ThePokerHandsKata
{
    /// <summary>Compares two five-card poker hands.</summary>
    public class PokerHands
    {
        /// <summary>Returns a winner summary, or "Tie", for two space-separated hands.</summary>
        public static string Compare(string blackHand, string whiteHand)
        {
            var black = Evaluate(ParseHand(blackHand));
            var white = Evaluate(ParseHand(whiteHand));
            var comparison = CompareValues(black, white);

            if (comparison == 0)
                return "Tie";

            var winner = comparison > 0 ? "Black" : "White";
            var winningHand = comparison > 0 ? black : white;
            var description = winningHand.Description;
            if (winningHand.Category == 0)
            {
                for (var index = 0; index < black.TieBreakers.Length; index++)
                    if (black.TieBreakers[index] != white.TieBreakers[index])
                    {
                        description = "high card: " + RankName(winningHand.TieBreakers[index]);
                        break;
                    }
            }

            return winner + " wins - " + description;
        }

        private static Card[] ParseHand(string hand)
        {
            if (hand == null)
                throw new ArgumentNullException("hand");

            var tokens = hand.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length != 5)
                throw new ArgumentException("A poker hand must contain exactly five cards.", "hand");

            var cards = tokens.Select(ParseCard).ToArray();
            if (cards.Select(card => card.Rank.ToString() + card.Suit).Distinct().Count() != 5)
                throw new ArgumentException("A hand cannot contain the same card more than once.", "hand");

            return cards;
        }

        private static Card ParseCard(string token)
        {
            if (string.IsNullOrEmpty(token) || token.Length < 2)
                throw new ArgumentException("Each card must contain a rank and suit.", "hand");

            var suit = char.ToUpperInvariant(token[token.Length - 1]);
            if (suit != 'C' && suit != 'D' && suit != 'H' && suit != 'S')
                throw new ArgumentException("Card suits must be C, D, H, or S.", "hand");

            var rankText = token.Substring(0, token.Length - 1).ToUpperInvariant();
            int rank;
            switch (rankText)
            {
                case "2": rank = 2; break;
                case "3": rank = 3; break;
                case "4": rank = 4; break;
                case "5": rank = 5; break;
                case "6": rank = 6; break;
                case "7": rank = 7; break;
                case "8": rank = 8; break;
                case "9": rank = 9; break;
                case "10":
                case "T": rank = 10; break;
                case "J": rank = 11; break;
                case "Q": rank = 12; break;
                case "K": rank = 13; break;
                case "A": rank = 14; break;
                default: throw new ArgumentException("Card ranks must be 2 through 10, J, Q, K, or A.", "hand");
            }

            return new Card(rank, suit);
        }

        private static HandValue Evaluate(Card[] cards)
        {
            var counts = new int[15];
            foreach (var card in cards)
                counts[card.Rank]++;

            var groups = Enumerable.Range(2, 13)
                .Where(rank => counts[rank] > 0)
                .OrderByDescending(rank => counts[rank])
                .ThenByDescending(rank => rank)
                .ToArray();
            var ranksDescending = cards.Select(card => card.Rank).OrderByDescending(rank => rank).ToArray();
            var flush = cards.All(card => card.Suit == cards[0].Suit);
            var straightHigh = GetStraightHigh(counts);

            if (flush && straightHigh > 0)
                return new HandValue(8, new[] { straightHigh }, "straight flush");
            if (groups.Length > 0 && counts[groups[0]] == 4)
                return new HandValue(7, new[] { groups[0], groups[1] }, "four of a kind: " + RankName(groups[0]));
            if (groups.Length == 2 && counts[groups[0]] == 3 && counts[groups[1]] == 2)
                return new HandValue(6, new[] { groups[0], groups[1] }, "full house: " + RankName(groups[0]));
            if (flush)
                return new HandValue(5, ranksDescending, "flush");
            if (straightHigh > 0)
                return new HandValue(4, new[] { straightHigh }, "straight: " + RankName(straightHigh));
            if (counts[groups[0]] == 3)
            {
                var kickers = ranksDescending.Where(rank => rank != groups[0]).ToArray();
                return new HandValue(3, new[] { groups[0] }.Concat(kickers).ToArray(), "three of a kind: " + RankName(groups[0]));
            }
            if (groups.Length == 3 && counts[groups[0]] == 2 && counts[groups[1]] == 2)
                return new HandValue(2, new[] { groups[0], groups[1], groups[2] }, "two pairs");
            if (counts[groups[0]] == 2)
            {
                var kickers = ranksDescending.Where(rank => rank != groups[0]).ToArray();
                return new HandValue(1, new[] { groups[0] }.Concat(kickers).ToArray(), "pair: " + RankName(groups[0]));
            }

            return new HandValue(0, ranksDescending, "high card: " + RankName(ranksDescending[0]));
        }

        private static int GetStraightHigh(int[] counts)
        {
            for (var high = 14; high >= 5; high--)
            {
                var isStraight = true;
                for (var rank = high - 4; rank <= high; rank++)
                    if (counts[rank] == 0)
                        isStraight = false;
                if (isStraight)
                    return high;
            }

            return counts[14] > 0 && counts[2] > 0 && counts[3] > 0 && counts[4] > 0 && counts[5] > 0 ? 5 : 0;
        }

        private static int CompareValues(HandValue first, HandValue second)
        {
            if (first.Category != second.Category)
                return first.Category.CompareTo(second.Category);

            for (var index = 0; index < first.TieBreakers.Length; index++)
            {
                var comparison = first.TieBreakers[index].CompareTo(second.TieBreakers[index]);
                if (comparison != 0)
                    return comparison;
            }

            return 0;
        }

        private static string RankName(int rank)
        {
            switch (rank)
            {
                case 14: return "Ace";
                case 13: return "King";
                case 12: return "Queen";
                case 11: return "Jack";
                default: return rank.ToString();
            }
        }

        private sealed class Card
        {
            public Card(int rank, char suit) { Rank = rank; Suit = suit; }
            public int Rank { get; private set; }
            public char Suit { get; private set; }
        }

        private sealed class HandValue
        {
            public HandValue(int category, int[] tieBreakers, string description)
            {
                Category = category;
                TieBreakers = tieBreakers;
                Description = description;
            }
            public int Category { get; private set; }
            public int[] TieBreakers { get; private set; }
            public string Description { get; private set; }
        }
    }
}
