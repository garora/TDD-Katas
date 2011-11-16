using System;
using NUnit.Framework;

namespace TDD_Katas_project.BowlingGame
{
    [TestFixture]
    public class TestGame
    {
        [Test]
        [TestCase(0, 0)]
        public void Can_Get_Calculate_Scores(int pins, int result)
        {
            var g = new Game();
            for (var i = 0; i < 20; i++)
            {
                g.Roll(pins);
            }
            Assert.That(result, Is.EqualTo(g.Score()));
        }
        

    }
}
