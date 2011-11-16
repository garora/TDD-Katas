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
        public void Can_Get_Calculate_Scores(int pins, int result)
        {
            
            for (var i = 0; i < 20; i++)
            {
                _game.Roll(pins);
            }
            Assert.That(result, Is.EqualTo(_game.Score()));
        }

        public void FrameHits(int pin)
        {
            for (var i = 0; i < 20; i++)
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
