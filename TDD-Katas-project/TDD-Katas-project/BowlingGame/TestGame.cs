using System;
using NUnit.Framework;

namespace TDD_Katas_project.BowlingGame
{
    [TestFixture]
    public class TestGame
    {
        [Test]
        public void Can_Roll()
        {
            var g = new Game();
            var result = g.Roll(0);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void Can_Get_Score()
        {
            var g = new Game();
            var result = g.Score();
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
