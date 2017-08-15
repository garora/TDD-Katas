// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using TDD_Katas_project.Common.Utility;

namespace TDD_Katas_project.TheNaturalStringSortingKata
{
    public class NaturalStringSorting
    {
        #region Member variables
        public enum SortOrder
        {
            Ascending, Descending
        }
        #endregion

        #region Public Methods

        public List<string> SortString(string[] strItems)
        {
            return SortString(strItems, SortOrder.Ascending);
        }

        public List<string> SortString(string[] strItems, SortOrder order)
        {
            Func<string, object> convert = str =>
                {
                    try
                    {
                        return int.Parse(str);
                    }
                    catch
                    {
                        return str;
                    }
                };

            return GetSortedList(strItems, order, convert);

        }
        #endregion

        #region Private Method

        private static List<string> GetSortedList(IEnumerable<string> strItems, SortOrder order, Func<string, object> convert)
        {
            List<string> sorted;
            switch (order)
            {
                case SortOrder.Descending:
                    sorted = strItems.OrderByDescending(
                        str => Regex.Split(str.Replace(" ", ""), "([0-9]+)").Select(convert),
                        new EnumerableComparer<object>()).ToList();
                    break;
                default:
                    sorted = strItems.OrderBy(
                        str => Regex.Split(str.Replace(" ", ""), "([0-9]+)").Select(convert),
                        new EnumerableComparer<object>()).ToList();
                    break;
            }
            return sorted;
        }

        #endregion
    }
}