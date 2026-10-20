// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System.Linq;
using NUnit.Framework;

namespace TDD_Katas_project.TheReversiKata
{
    [TestFixture]
    [Category("The Reversi Kata")]
    public class ReversiTest
    {
        private static readonly string[] InitialBoard =
        {
            "........", "........", "........", "...BW...",
            "...WB...", "........", "........", "........"
        };

        [Test]
        public void FindsTheFourLegalOpeningMoves()
        {
            var moves = Reversi.GetLegalMoves(InitialBoard, 'B');
            var coordinates = moves.Select(move => move.Row + "," + move.Column).ToArray();
            Assert.That(coordinates, Is.EquivalentTo(new[] { "2,3", "3,2", "4,5", "5,4" }));
        }

        [Test]
        public void MarksMovesWithoutChangingTheInputBoard()
        {
            var result = Reversi.MarkLegalMoves(InitialBoard, 'B');
            Assert.That(result, Is.EqualTo(new[]
            {
                "........", "........", "...0....", "..0BW...",
                "...WB0..", "....0...", "........", "........"
            }));
            Assert.That(InitialBoard[2], Is.EqualTo("........"));
        }

        [Test]
        public void ReturnsNoMovesWhenNoOpponentCanBeCaptured()
        {
            var board = Enumerable.Repeat("........", 8).ToArray();
            Assert.That(Reversi.GetLegalMoves(board, 'W'), Is.Empty);
        }

        [Test]
        public void RejectsInvalidBoardDimensions()
        {
            Assert.Throws<System.ArgumentException>(() => Reversi.GetLegalMoves(new[] { "........" }, 'B'));
        }
    }
}
