using System.Collections.Generic;
using NUnit.Framework;

namespace TDD_Katas_project.The_CalcStats_Kata
{
    [TestFixture]
    [Category("The CalcStats Kata")]
    public class CalcStatTest
    {
        private static IList<int> List(params int[] numbers)
        {
            IList<int> list = new List<int>();
            foreach (var i in numbers)
            {
                list.Add(i);
            }
            return list;
        }
        [Test]
        public void NumberStatTest()
        {
            Assert.That(List(1, 2), Is.EqualTo(CalcStat.NumberStats(List(1, 2),CalcStat.CalcStatKeys.Minimum)));
        }
    }
}
