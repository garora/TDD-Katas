using System;
using NUnit.Framework;

namespace TDD_Katas_project.BowlingGame
{
    [TestFixture]
    public class TestGame
    {
        private Game _game = null;
        [SetUp]
        public void Setup()
        {
            _game = new Game();
        }
        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 20)]
        [TestCase(5,18)]
        public void Can_Get_Calculate_Scores(int pins, int result)
        {
            FrameHits(pins, 20);
            Assert.That(result, Is.EqualTo(_game.Score()));
        }

        public void FrameHits(int pin, int count)
        {
            for (var i = 0; i < count; i++)
            {
                _game.Roll(pin);

            }
        }

        [TearDown]
        public void TearDown()
        {
            _game = null;
        }
    }
}
