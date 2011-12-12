using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TDD_Katas_project.The_LeapYear_Kata
{
    [TestFixture]
    public class LeapYearTest
    {
        [Test]
        public void CanTestForLeapYear()
        {
            Assert.That(true,Is.EqualTo(LeapYear.IsLeapYear(2001)));
        }
    }
}
