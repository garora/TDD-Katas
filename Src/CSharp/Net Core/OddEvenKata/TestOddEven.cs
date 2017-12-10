// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.

using NUnit.Framework;

namespace TDD_Katas_NETCore.OddEvenKata
{
    [TestFixture]
    [Category("OddEven Kata NET Core")]
    public class TestOddEven
    {
        [Test]
        [TestCase(1, 50)]
        [TestCase(1, 100)]
        [TestCase(5, 150)]
        public void CanPrintOddEven(int startRange, int endRange)
        {
            var result = OddEven.PrintOddEven(startRange, endRange);
            Assert.NotNull(result, string.Format("{0}", result));
        }

        [Test]
        [TestCase(1, "Odd")]
        [TestCase(3, "3")]
        [TestCase(5, "5")]
        [TestCase(4, "Even")]
        [TestCase(9, "Odd")]
        [TestCase(10, "Even")]
        public void CanPrintOddEvenForSingleNumber(int number, string expectedresult)
        {
            var actualresult = OddEven.PrintSingleOddEven(number);
            Assert.That(expectedresult, Is.EqualTo(actualresult),
                string.Format("result of entered number [{0}] is [{1}] but it should be [{2}]", number,
                    actualresult, expectedresult));
        }
    }
}