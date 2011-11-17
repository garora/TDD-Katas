using System;
using NUnit.Framework;

namespace TDD_Katas_project.BowlingGame
{
    [TestFixture]
    [Category("TheBowlingGameKata")]
    public class TestGame
    {
        private Game _game;
        private int _frames;

        #region Setup/TearDown
        [TestFixtureSetUp]
        public void Setup()  
        {
            _game = new Game();
            _frames = 20;
        }
        [TestFixtureTearDown]
        public void TearDown()
        {
            _game = null;
            _frames = 0;
        }
        #endregion

        #region TestMethods

        [Test]
        [TestCase(0,0)]
        [TestCase(0, 20)]
        [TestCase(1, 20)]
        [TestCase(5, 18)]
        public void Can_Get_Calculate_Scores(int pins, int result)
        {
            FrameHits(pins, _frames);
            Assert.That(result, Is.EqualTo(_game.Score()));
        }
        #endregion

        #region Private Methods
        private void FrameHits(int pin, int count)
        {
            for (var i = 0; i < count; i++)
            {
                _game.Roll(pin);

            }
        }
        #endregion

    }
}
