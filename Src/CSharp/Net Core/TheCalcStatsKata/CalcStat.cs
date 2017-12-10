// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace TDD_Katas_NETCore.TheCalcStatsKata
{
    public class CalcStat
    {
        public enum CalcStatKeys
        {
            Minimum = 1,
            Maximum = 2,
            ElementCount = 3,
            Average = 4
        }


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


        private static string GetMinimumValue(IEnumerable<int> numbers)
        {
            return numbers?.Min().ToString(CultureInfo.InvariantCulture);
        }

        private static string GetMaximumValue(IEnumerable<int> numbers)
        {
            return numbers?.Max().ToString(CultureInfo.InvariantCulture);
        }

        private static string GetElementCount(IEnumerable<int> numbers)
        {
            return numbers?.Count().ToString(CultureInfo.InvariantCulture);
        }

        private static string GetSeriesAverage(IEnumerable<int> numbers) => numbers?.Average().ToString(CultureInfo.InvariantCulture);
    }
}