using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TDD_Katas_project.The_CalcStats_Kata
{
    [TestFixture]
    [Category("The CalcStats Kata")]
    public class CalcStatTest
    {
        private static IList<int> List(params int[] numbers)
        {
            return numbers.ToList();
        }

        [Test]
        public void NumberStatTest()
        {
            Assert.That("-2", Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.Minimum)));
            Assert.That("92", Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.Maximum)));
            Assert.That("10", Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.ElementCount)));
            Assert.That("10", Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.Average)));
        }
    }
}
