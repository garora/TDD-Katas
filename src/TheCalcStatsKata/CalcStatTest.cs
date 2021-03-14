// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace TDD_Katas_project.TheCalcStatsKata
{
    /// <summary>
    /// Calc Stat tests
    /// </summary>
    [TestFixture]
    [Category("The CalcStats Kata")]
    public class CalcStatTest
    {
       private static IList<int> List(params int[] numbers) => numbers.ToList();

        /// <summary>
        /// Determines whether this instance [can find minum value].
        /// </summary>
        [Test]
        public void CanFindMinumValue() => Assert.That("-2", Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.Minimum)));

        /// <summary>
        /// Determines whether this instance [can find maximum value].
        /// </summary>
        [Test]
        public void CanFindMaximumValue() => Assert.That("10", Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.ElementCount)));

        /// <summary>
        /// Determines whether this instance [can get element count].
        /// </summary>
        [Test]
        public void CanGetElementCount() => Assert.That("10", Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.ElementCount)));

        /// <summary>
        /// Determines whether this instance [can get average of series].
        /// </summary>
        [Test]
        public void CanGetAverageOfSeries() => Assert.That("13.1", Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.Average)));
               
    }
}