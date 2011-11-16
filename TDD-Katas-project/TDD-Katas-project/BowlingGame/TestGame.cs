using System;
using NUnit.Framework;

namespace TDD_Katas_project.BowlingGame
{
    [TestFixture]
    public class TestGame
    {
        [Test]
        public void Can_Get_Calculate_Scores()
        {
            var g = new Game();
            Assert.That(0, Is.EqualTo(g.Score()));
        }
       
    }
}
