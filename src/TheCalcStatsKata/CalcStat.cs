// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace TDD_Katas_project.TheCalcStatsKata
{
    /// <summary>
    /// Calc Stat
    /// </summary>
    public class CalcStat
    {
        /// <summary>
        /// Calc Stat Keys
        /// </summary>
        public enum CalcStatKeys
        {
            /// <summary>
            /// The minimum
            /// </summary>
            Minimum = 1,
            /// <summary>
            /// The maximum
            /// </summary>
            Maximum = 2,
            /// <summary>
            /// The element count
            /// </summary>
            ElementCount = 3,
            /// <summary>
            /// The average
            /// </summary>
            Average = 4
        }


        /// <summary>
        /// Numbers the stats.
        /// </summary>
        /// <param name="numbers">The numbers.</param>
        /// <param name="keys">The keys.</param>
        /// <returns></returns>
        public static string NumberStats(IList<int> numbers, CalcStatKeys keys)
        {
            switch (keys)
            {
                case CalcStatKeys.Minimum:
                    return GetMinimumValue(numbers);
                case CalcStatKeys.Maximum:
                    return GetMaximumValue(numbers);
                case CalcStatKeys.ElementCount:
                    return GetElementCount(numbers);
                case CalcStatKeys.Average:
                    return GetSeriesAverage(numbers);
            }
            return null;
        }

        private static string GetMinimumValue(IEnumerable<int> numbers) => numbers?.Min().ToString(CultureInfo.InvariantCulture);

        private static string GetMaximumValue(IEnumerable<int> numbers) => numbers?.Max().ToString(CultureInfo.InvariantCulture);

        private static string GetElementCount(IEnumerable<int> numbers) => numbers?.Count().ToString(CultureInfo.InvariantCulture);

        private static string GetSeriesAverage(IEnumerable<int> numbers) => numbers?.Average().ToString(CultureInfo.InvariantCulture);
    }
}