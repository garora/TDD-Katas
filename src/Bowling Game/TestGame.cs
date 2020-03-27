using System;
using NUnit.Framework;

namespace TDD_Katas_NETCore.Bowling_Game
{
    [TestFixture]
    [Category("TheBowlingGameKataNETCore")]
    public class TestGame
    {
        [SetUp]
        public void Setup()
        {
            _game = new Game();
            _frames = 10;
        }

        [TearDown]
        public void TearDown()
        {
            _game = null;
            _frames = 0;
        }

        private Game _game;
        private int _frames;

        private void RollStrike()
        {
            _game.Roll(10);
        }

        private void FrameHits(int pin, int count)
        {
            for (var i = 0; i < count; i++)
                _game.Roll(pin);
        }

        private void RollSpare()
        {
            _game.Roll(5);
            _game.Roll(5);
        }

        [Test]
        public void Can_Get_Calculate_Full_Game_Scores()
        {
            FrameHits(10, 12);
            Console.WriteLine("Roll Total - {0}, Result - {1}", 300, _game.Score());
            Assert.That(300, Is.EqualTo(_game.Score()));
        }


        [Test]
        public void Can_Get_Calculate_Scores()
        {
            FrameHits(0, _frames);
            Assert.That(0, Is.EqualTo(_game.Score()));
        }

        [Test]
        public void Can_Get_Calculate_Single_Scores()
        {
            _game.Roll(0);
            Console.WriteLine("Roll Total - {0}, Result - {1}", 0, _game.Score());
            Assert.That(0, Is.EqualTo(_game.Score()));
        }

        [Test]
        public void Can_Get_Calculate_Spare_Scores()
        {
            RollSpare();
            _game.Roll(3);
            FrameHits(0, 17);
            Console.WriteLine("Roll Total - {0}, Result - {1}", 16, _game.Score());
            Assert.That(16, Is.EqualTo(_game.Score()));
        }

        [Test]
        public void Can_Get_Calculate_Strike_Scores()
        {
            RollStrike();
            _game.Roll(3);
            _game.Roll(4);
            FrameHits(0, 16);
            Console.WriteLine("Roll Total - {0}, Result - {1}", 24, _game.Score());
            Assert.That(24, Is.EqualTo(_game.Score()));
        }
    }
}