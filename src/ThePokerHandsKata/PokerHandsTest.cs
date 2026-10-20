// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using NUnit.Framework;

namespace TDD_Katas_project.ThePokerHandsKata
{
    [TestFixture]
    [Category("The Poker Hands Kata")]
    public class PokerHandsTest
    {
        [TestCase("2H 3D 5S 9C KD", "2C 3H 4S 8C AH", "White wins - high card: Ace")]
        [TestCase("2H 4S 4C 3D 4H", "2S 8S AS QS 3S", "White wins - flush")]
        [TestCase("2H 3D 5S 9C KD", "2C 3H 4S 8C KH", "Black wins - high card: King")]
        [TestCase("2H 3D 5S 9C KD", "2D 3H 5C 9S KH", "Tie")]
        [TestCase("2H 2D 5S 9C KD", "3H 3D 4S 8C AH", "White wins - pair: 3")]
        [TestCase("2H 3D 4S 5C 6D", "AH 2D 3C 4H 5S", "Black wins - straight: 6")]
        [TestCase("2H 2D 2S 2C 3D", "AH AD AS AC KS", "White wins - four of a kind: Ace")]
        public void ComparesHands(string black, string white, string expected)
        {
            Assert.That(PokerHands.Compare(black, white), Is.EqualTo(expected));
        }

        [Test]
        public void RequiresFiveCardsPerHand()
        {
            Assert.Throws<System.ArgumentException>(() => PokerHands.Compare("AH KD", "2H 3D 4S 5C 6H"));
        }
    }
}
