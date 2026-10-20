// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using NUnit.Framework;

namespace TDD_Katas_project.ThePrimeCompositeKata
{
    [TestFixture]
    [Category("The PrimeComposite Kata")]
    public class PrimeCompositeTest
    {
        [TestCase(2, "Prime")]
        [TestCase(3, "Prime")]
        [TestCase(1, "1")]
        [TestCase(0, "0")]
        [TestCase(4, "4")]
        [TestCase(9, "Composite")]
        [TestCase(15, "Composite")]
        public void ClassifiesSingleNumbers(int number, string expected)
        {
            Assert.That(PrimeComposite.Classify(number), Is.EqualTo(expected));
        }

        [Test]
        public void PrintsInclusiveRangeUsingPrimeCompositeRules()
        {
            Assert.That(PrimeComposite.PrintRange(1, 10),
                Is.EqualTo("1 Prime Prime 4 Prime 6 Prime 8 Composite 10"));
        }

        [Test]
        public void ReturnsEmptyForReversedRange()
        {
            Assert.That(PrimeComposite.PrintRange(5, 4), Is.Empty);
        }
    }
}
