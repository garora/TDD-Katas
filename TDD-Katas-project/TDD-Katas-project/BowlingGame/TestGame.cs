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
            _frames = 10;
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
        public void Can_Get_Calculate_Single_Scores()
        {
            _game.Roll(0);
            Console.WriteLine(string.Format("Roll Total - {0}, Result - {1}", 0, _game.Score()));
            Assert.That(0, Is.EqualTo(_game.Score()));
        }
        [Test]
        public void Can_Get_Calculate_Spare_Scores()
        {
            _game.Roll(5);
            _game.Roll(5);
            _game.Roll(1);

            Console.WriteLine(string.Format("Roll Total - {0}, Result - {1}", 12, _game.Score()));
            Assert.That(12, Is.EqualTo(_game.Score()));
        }
        [Test]
        [Ignore]
        [TestCase(0, 0)]
        [TestCase(1, 20)]
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
