// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;

namespace TDD_Katas_project.StringSum
{
    /// <summary>
    /// String Sum Kata
    /// </summary>
    public class StringSumKata
    {
        /// <summary>
        /// Sums the specified num1.
        /// </summary>
        /// <param name="num1">The num1.</param>
        /// <param name="num2">The num2.</param>
        /// <returns></returns>
        public static string Sum(string num1, string num2)
        {
            var realNum1 = GetZeroWhenNullOrEmpty(num1);
            var realNum2 = GetZeroWhenNullOrEmpty(num2);

            return Convert.ToString(Add(realNum1, realNum2));
        }

        private static string GetZeroWhenNullOrEmpty(string num1) => string.IsNullOrEmpty(num1) ? "0" : num1;

        private static int Add(string realNum1, string realNum2) => int.Parse(realNum1) + int.Parse(realNum2);
    }
}
