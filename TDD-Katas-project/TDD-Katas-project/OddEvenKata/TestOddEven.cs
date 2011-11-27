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
        public void CanPrintOddEven()
        {
            var result = OddEven.PrintOddEven();
            Assert.NotNull(result);
        }
    }
}
