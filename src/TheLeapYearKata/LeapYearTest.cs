// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using NUnit.Framework;

namespace TDD_Katas_project.TheLeapYearKata
{
    /// <summary>
    /// Leap Year Tests
    /// </summary>
    [TestFixture]
    [Category("The LeapYear")]
    public class LeapYearTest
    {
        /// <summary>
        /// Determines whether this instance [can test for leap year].
        /// </summary>
        [Test]
        public void CanTestForLeapYear() => Assert.That(true, Is.EqualTo(LeapYear.IsLeapYear(1996)));

        /// <summary>
        /// Determines whether this instance [can test for leap years] the specified expected result.
        /// </summary>
        /// <param name="expectedResult">if set to <c>true</c> [expected result].</param>
        /// <param name="year">The year.</param>
        [Test]
        [TestCase(false, 2013)]
        [TestCase(false, 2001)]
        [TestCase(true, 1996)]
        [TestCase(true, 1992)]
        public void CanTestForLeapYears(bool expectedResult, int year) => Assert.That(expectedResult, Is.EqualTo(LeapYear.IsLeapYear(year)));
    }
}
