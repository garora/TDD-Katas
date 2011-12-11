using System;
using System.Collections.Generic;
using System.Linq;

namespace TDD_Katas_project.The_CalcStats_Kata
{
    public class CalcStat
    {
        public enum CalcStatKeys
        {
            Minimum = 1, Maximum = 2, ElementCount = 3, Average = 4
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
            return numbers == null ? null : numbers.Min().ToString();
        }
        private static string GetMaximumValue(IEnumerable<int> numbers)
        {
            return numbers == null ? null : numbers.Max().ToString();
        }
        private static string GetElementCount(IEnumerable<int> numbers)
        {
            return numbers == null ? null : numbers.Count().ToString();
        }
        private static string GetSeriesAverage(IEnumerable<int> numbers)
        {
            return numbers == null ? null : numbers.Average().ToString();
        }
    }
}
