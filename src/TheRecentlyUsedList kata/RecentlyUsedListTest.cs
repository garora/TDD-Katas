// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TDD_Katas_project.TheRecentlyUsedList_kata
{
    /// <summary>
    /// The Recently Used List Kata
    /// </summary>
    [TestFixture]
    [Category("The Recently Used List Kata")]
    public class RecentlyUsedListTest
    {
        private RecentlyUsedList<string> _recentlyUsedList;
        private int _size;

        /// <summary>
        /// Setups this instance.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            _recentlyUsedList = new RecentlyUsedList<string>();
            _size = 10;
        }
        /// <summary>
        /// Tears down.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            _recentlyUsedList = null;
            _size = -1;
        }


        /// <summary>
        /// Determines whether this instance [can add items].
        /// </summary>
        [Test]
        public void CanAddItems()
        {
            _recentlyUsedList.Add("FirstList");
            var listCount = _recentlyUsedList.Count();
            Assert.That(listCount, Is.GreaterThan(0), string.Format("List items count should be Greater than {0} but is {1}", 0, listCount));

        }
        /// <summary>
        /// Determines whether this instance [can add unique items].
        /// </summary>
        [Test]
        public void CanAddUniqueItems()
        {
            _recentlyUsedList.Add("FirstItem");
            _recentlyUsedList.Add("SecondItem");
            _recentlyUsedList.Add("SecondItem");
            _recentlyUsedList.Add("ThirdItem");
            _recentlyUsedList.Add("FourthItem");
            _recentlyUsedList.Add("FifthItem");

            var expectedlist = ToList("FifthItem", "FourthItem", "ThirdItem", "SecondItem", "FirstItem");
            var actuallist = _recentlyUsedList.ToList();

            Assert.That(actuallist, Is.EqualTo(expectedlist));

        }
        /// <summary>
        /// Determines whether this instance [can add items in lifo order].
        /// </summary>
        [Test]
        public void CanAddItemsInLifoOrder()
        {
            _recentlyUsedList.Add("FirstItem");
            _recentlyUsedList.Add("SecondItem");
            _recentlyUsedList.Add("ThirdItem");
            _recentlyUsedList.Add("FourthItem");
            _recentlyUsedList.Add("FifthItem");
            var expectedlist = ToList("FifthItem", "FourthItem", "ThirdItem", "SecondItem", "FirstItem");
            var actuallist = _recentlyUsedList.ToList();

            Assert.That(actuallist, Is.EqualTo(expectedlist));

        }
        /// <summary>
        /// Determines whether this instance [can avoid insertion of items are beyond list size].
        /// </summary>
        [Test]
        public void CanAvoidInsertionOfItemsAreBeyondListSize()
        {
            _recentlyUsedList.Add("FirstItem");
            _recentlyUsedList.Add("SecondItem");
            _recentlyUsedList.Add("SecondItem");
            _recentlyUsedList.Add("ThirdItem");
            _recentlyUsedList.Add("FourthItem");
            _recentlyUsedList.Add("FifthItem");
            _recentlyUsedList.Add("SixthItem"); //This should not be considered
            _recentlyUsedList.Add("SeventhItem"); //This should not be considered

            var expectedlist = ToList("FifthItem", "FourthItem", "ThirdItem", "SecondItem", "FirstItem");
            var actuallist = _recentlyUsedList.ToList();

            Assert.That(actuallist, Is.EqualTo(expectedlist));

        }
        /// <summary>
        /// Determines whether this instance [can test item by index].
        /// </summary>
        [Test]
        public void CanTestItemByIndex()
        {
            _recentlyUsedList.Add("FirstItem");
            _recentlyUsedList.Add("SecondItem");
            _recentlyUsedList.Add("ThirdItem");
            _recentlyUsedList.Add("FourthItem");
            _recentlyUsedList.Add("FifthItem");
            const string expectedlistitem = "SecondItem";
            var actuallistitem = _recentlyUsedList.GetListItem(3);

            Assert.That(actuallistitem, Is.EqualTo(expectedlistitem));
        }
        /// <summary>
        /// Determines whether this instance [can test default list size].
        /// </summary>
        [Test]
        public void CanTestDefaultListSize()
        {
            const int expectedlistSize = 5;
            var actuallistsize = _recentlyUsedList.Size;
            Assert.That(actuallistsize, Is.EqualTo(expectedlistSize));
        }
        /// <summary>
        /// Determines whether this instance [can throw argument exception when supplied index is out of scope].
        /// </summary>
        [Test]
        public void CanThrowArgumentExceptionWhenSuppliedIndexIsOutOfScope()
        {
            _recentlyUsedList.Add("FirstItem");
            _recentlyUsedList.Add("SecondItem");
            _recentlyUsedList.Add("ThirdItem");
            _recentlyUsedList.Add("FourthItem");
            _recentlyUsedList.Add("FifthItem");
            const int index = 5;
            var exception = Assert.Throws<ArgumentException>(() => _recentlyUsedList.GetListItem(index));

            Assert.That(exception.Message, Is.EqualTo(string.Format("supplied index [{0}] should not greater than [{1}].", index, _recentlyUsedList.Count - 1)));
        }
        /// <summary>
        /// Determines whether this instance [can throw argument exception when supplied index contain negative value].
        /// </summary>
        [Test]
        public void CanThrowArgumentExceptionWhenSuppliedIndexContainNegativeValue()
        {
            _recentlyUsedList.Add("FirstItem");
            _recentlyUsedList.Add("SecondItem");
            _recentlyUsedList.Add("ThirdItem");
            _recentlyUsedList.Add("FourthItem");
            _recentlyUsedList.Add("FifthItem");
            const int index = -1;
            var exception = Assert.Throws<ArgumentException>(() => _recentlyUsedList.GetListItem(index));
            Assert.That(exception.Message, Is.EqualTo(string.Format("supplied index [{0}] should be non-negative and not greater than [{1}].", index, _recentlyUsedList.Count - 1)));

        }
        /// <summary>
        /// Determines whether this instance [can throw argument exception when supplied item is nullor empty].
        /// </summary>
        [Test]
        public void CanThrowArgumentExceptionWhenSuppliedItemIsNullorEmpty()
        {
            var list = ToList(null, string.Empty);

            foreach (var item in list)
            {
                var item1 = item;
                var exception = Assert.Throws<ArgumentException>(() => _recentlyUsedList.Add(item1));
                Assert.That(exception.Message,
                        Is.EqualTo(string.Format("List items should not be Empty or Null. But it was [{0}]", item1)));
            }

        }
        /// <summary>
        /// Determines whether this instance [can define list size].
        /// </summary>
        [Test]
        public void CanDefineListSize()
        {
            var sizeableList = new RecentlyUsedList<string>(_size);
            Assert.That(_size, Is.EqualTo(sizeableList.Size));
        }
              
        private List<string> ToList(params string[] items) => items.ToList();

    }
}
