using NUnit.Framework;

namespace TDD_Katas_project.The_LeapYear_Kata
{
    [TestFixture]
    public class LeapYearTest
    {
        [Test]
        public void CanTestForLeapYear()
        {
            Assert.That(false,Is.EqualTo(LeapYear.IsLeapYear(2001)));
        }
    }
}
