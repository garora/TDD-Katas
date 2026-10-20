// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using NUnit.Framework;

namespace TDD_Katas_project.TheYahtzeeKata
{
    [TestFixture]
    [Category("The Yahtzee Kata")]
    public class YahtzeeTest
    {
        [TestCase(YahtzeeCategory.Chance, 14, new int[] { 1, 1, 3, 3, 6 })]
        [TestCase(YahtzeeCategory.Yahtzee, 50, new int[] { 1, 1, 1, 1, 1 })]
        [TestCase(YahtzeeCategory.Yahtzee, 0, new int[] { 1, 1, 1, 2, 1 })]
        [TestCase(YahtzeeCategory.Fours, 8, new int[] { 1, 1, 2, 4, 4 })]
        [TestCase(YahtzeeCategory.Twos, 4, new int[] { 2, 3, 2, 5, 1 })]
        [TestCase(YahtzeeCategory.Pair, 8, new int[] { 3, 3, 3, 4, 4 })]
        [TestCase(YahtzeeCategory.TwoPairs, 8, new int[] { 1, 1, 2, 3, 3 })]
        [TestCase(YahtzeeCategory.ThreeOfAKind, 9, new int[] { 3, 3, 3, 4, 5 })]
        [TestCase(YahtzeeCategory.FourOfAKind, 8, new int[] { 2, 2, 2, 2, 5 })]
        [TestCase(YahtzeeCategory.SmallStraight, 15, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(YahtzeeCategory.LargeStraight, 20, new int[] { 2, 3, 4, 5, 6 })]
        [TestCase(YahtzeeCategory.FullHouse, 8, new int[] { 1, 1, 2, 2, 2 })]
        public void ScoresRoll(YahtzeeCategory category, int expected, int[] dice)
        {
            Assert.That(Yahtzee.Score(dice, category), Is.EqualTo(expected));
        }

        [Test]
        public void RejectsRollsThatDoNotContainFiveValidDice()
        {
            Assert.Throws<System.ArgumentException>(() => Yahtzee.Score(new int[] { 1, 2, 3 }, YahtzeeCategory.Chance));
            Assert.Throws<System.ArgumentOutOfRangeException>(() => Yahtzee.Score(new int[] { 1, 2, 3, 4, 7 }, YahtzeeCategory.Chance));
        }
    }
}
