// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using System.Linq;

namespace TDD_Katas_project.TheYahtzeeKata
{
    /// <summary>Scoring categories for the Yahtzee kata.</summary>
    public enum YahtzeeCategory
    {
        Chance, Yahtzee, Ones, Twos, Threes, Fours, Fives, Sixes,
        Pair, TwoPairs, ThreeOfAKind, FourOfAKind, SmallStraight, LargeStraight, FullHouse
    }

    /// <summary>Scores a five-dice roll in a caller-selected category.</summary>
    public class Yahtzee
    {
        /// <summary>Returns the score for the supplied five dice and category.</summary>
        public static int Score(int[] dice, YahtzeeCategory category)
        {
            ValidateDice(dice);
            var counts = new int[7];
            foreach (var die in dice)
                counts[die]++;

            switch (category)
            {
                case YahtzeeCategory.Chance:
                    return dice.Sum();
                case YahtzeeCategory.Yahtzee:
                    return counts.Skip(1).Any(count => count == 5) ? 50 : 0;
                case YahtzeeCategory.Ones:
                case YahtzeeCategory.Twos:
                case YahtzeeCategory.Threes:
                case YahtzeeCategory.Fours:
                case YahtzeeCategory.Fives:
                case YahtzeeCategory.Sixes:
                    var face = (int)category - (int)YahtzeeCategory.Ones + 1;
                    return counts[face] * face;
                case YahtzeeCategory.Pair:
                    for (var value = 6; value >= 1; value--)
                        if (counts[value] == 2)
                            return value * 2;
                    return 0;
                case YahtzeeCategory.TwoPairs:
                    var pairs = Enumerable.Range(1, 6).Where(value => counts[value] == 2).OrderByDescending(value => value).ToArray();
                    return pairs.Length == 2 ? (pairs[0] + pairs[1]) * 2 : 0;
                case YahtzeeCategory.ThreeOfAKind:
                    return MatchingKindScore(counts, 3);
                case YahtzeeCategory.FourOfAKind:
                    return MatchingKindScore(counts, 4);
                case YahtzeeCategory.SmallStraight:
                    return HasStraight(counts, 1, 5) ? 15 : 0;
                case YahtzeeCategory.LargeStraight:
                    return HasStraight(counts, 2, 6) ? 20 : 0;
                case YahtzeeCategory.FullHouse:
                    return counts.Skip(1).Count(count => count == 3) == 1 &&
                           counts.Skip(1).Count(count => count == 2) == 1 ? dice.Sum() : 0;
                default:
                    throw new ArgumentOutOfRangeException("category", "Unknown Yahtzee category.");
            }
        }

        private static int MatchingKindScore(int[] counts, int requiredCount)
        {
            for (var value = 6; value >= 1; value--)
                if (counts[value] == requiredCount)
                    return value * requiredCount;
            return 0;
        }

        private static bool HasStraight(int[] counts, int first, int last)
        {
            for (var value = first; value <= last; value++)
                if (counts[value] != 1)
                    return false;
            return true;
        }

        private static void ValidateDice(int[] dice)
        {
            if (dice == null)
                throw new ArgumentNullException("dice");
            if (dice.Length != 5)
                throw new ArgumentException("A Yahtzee roll must contain exactly five dice.", "dice");
            if (dice.Any(die => die < 1 || die > 6))
                throw new ArgumentOutOfRangeException("dice", "Each die must be between 1 and 6.");
        }
    }
}
