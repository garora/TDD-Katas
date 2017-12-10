// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TDD_Katas_NETCore.TheNaturalStringSortingKata
{
    [TestFixture]
    [Category("The Natural String Kata NET Core")]
    public class NaturalStringSortingTest
    {
        private NaturalStringSorting _naturalStringSorting;
        private string[] _strings;

        [SetUp]
        public void Setup()
        {
            _naturalStringSorting = new NaturalStringSorting();
            _strings = new[] {"a1", "1", "3", "2", "b1", "1a", "b3", "23", "z 21", "21 1", "z22", "0"};
        }

        [TearDown]
        public void TearDown()
        {
            _naturalStringSorting = null;
            _strings = null;
        }

        private static List<string> ToList(params string[] items)
        {
            return items.ToList();
        }

        [Test]
        public void CanSortStringDefaultOrder()
        {
            var sortString = _naturalStringSorting.SortString(_strings);
            string[] result = {"0", "1", "1a", "2", "3", "23", "21 1", "a1", "b1", "b3", "z 21", "z22"};
            Assert.That(sortString, Is.EqualTo(ToList(result)));
        }

        [Test]
        public void CanSortStringDesOrder()
        {
            var sortString = _naturalStringSorting.SortString(_strings, NaturalStringSorting.SortOrder.Descending);
            string[] result = {"z22", "z 21", "b3", "b1", "a1", "21 1", "23", "3", "2", "1a", "1", "0"};
            Assert.That(sortString, Is.EqualTo(ToList(result)));
        }
    }
}