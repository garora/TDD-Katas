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
            var returnValue = string.Empty;
            if (keys == CalcStatKeys.Minimum)
                if (numbers != null) returnValue = numbers.Min().ToString();
            if (keys == CalcStatKeys.Maximum)
                if (numbers != null) returnValue = numbers.Max().ToString();
            return returnValue;
        }
    }
}
