using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
namespace TDD_Katas_project.OddEvenKata
{
    [TestFixture]
    [Category("OddEven Kata")]
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
        public void CanPrintOddEvenForSingleNumber(int number, string expectedresult)
        {
            var actualresult = OddEven.PringSingleOddEven(1);
            Assert.That(expectedresult, Is.EqualTo(actualresult),
                             string.Format("result of entered number [{0}] is [{1}] but it should be [{2}]", number,
                                           actualresult, expectedresult));

        }
    }
}
