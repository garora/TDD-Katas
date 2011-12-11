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
            Assert.That("-1", Is.EqualTo(CalcStat.NumberStats(List(1,-1, 2),CalcStat.CalcStatKeys.Minimum)));
        }
    }
}
