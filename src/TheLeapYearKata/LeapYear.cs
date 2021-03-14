// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace TDD_Katas_project.TheLeapYearKata
{
    /// <summary>
    /// Leap Year
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// Determines whether [is leap year] [the specified year].
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>
        ///   <c>true</c> if [is leap year] [the specified year]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLeapYear(int year) => year % 4 == 0 || year % 400 == 0;
    }
}
