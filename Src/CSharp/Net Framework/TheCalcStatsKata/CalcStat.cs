// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace TDD_Katas_project.TheCalcStatsKata
{
    public class CalcStat
    {
        #region Members
        public enum CalcStatKeys
        {
            Minimum = 1, Maximum = 2, ElementCount = 3, Average = 4
        }
        #endregion

        #region Public Methods
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
        #endregion

        #region Private Methods

        private static string GetMinimumValue(IEnumerable<int> numbers)
        {
            return numbers == null
                       ? null
                       : numbers.Min().ToString(CultureInfo.InvariantCulture);
        }
        private static string GetMaximumValue(IEnumerable<int> numbers)
        {
            return numbers == null
                       ? null
                       : numbers.Max().ToString(CultureInfo.InvariantCulture);
        }
        private static string GetElementCount(IEnumerable<int> numbers)
        {
            return numbers == null
                       ? null
                       : numbers.Count().ToString(CultureInfo.InvariantCulture);
        }
        private static string GetSeriesAverage(IEnumerable<int> numbers)
        {
            return numbers == null
                       ? null
                       : numbers.Average().ToString(CultureInfo.InvariantCulture);
        }
        #endregion
    }
}