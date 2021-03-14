// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using NUnit.Framework;

namespace TDD_Katas_project.StringSum
{
    /// <summary>
    /// Test String Sum Kata
    /// </summary>
    [TestFixture]
    [Category("StringSumkata")]
    public class TestStringSumKata
    {
        /// <summary>
        /// Adds the return sum.
        /// </summary>
        /// <param name="num1">The num1.</param>
        /// <param name="num2">The num2.</param>
        /// <param name="expectedResult">The expected result.</param>
        [TestCase("", null, "0")]
        [Test]
        public void AddReturnSum(string num1, string num2, string expectedResult)
        {
            var result = StringSumKata.Sum(num1, num2);

            Assert.That(expectedResult, Is.EqualTo(result));
        }
    }
}
