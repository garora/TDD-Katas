// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TDD_Katas_NETCore.TheCalcStatsKata
{
    [TestFixture]
    [Category("The CalcStats Kata NET Core")]
    public class CalcStatTest
    {
        private static IList<int> List(params int[] numbers) => numbers.ToList();

        [Test]
        public void CanFindMaximumValue()
        {
            Assert.That("10",
                Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11),
                    CalcStat.CalcStatKeys.ElementCount)));
        }

        [Test]
        public void CanFindMinumValue()
        {
            Assert.That("-2",
                Is.EqualTo(
                    CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.Minimum)));
        }

        [Test]
        public void CanGetAverageOfSeries()
        {
            Assert.That("13.1",
                Is.EqualTo(
                    CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.Average)));
        }

        [Test]
        public void CanGetElementCount()
        {
            Assert.That("10",
                Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11),
                    CalcStat.CalcStatKeys.ElementCount)));
        }
    }
}