using System;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;
namespace TDD_Katas_project.The_RecentlyUsedList_kata
{
    [TestFixture]
    [Category("The Recently Used List Kata")]
    public class RecentlyUsedListTest
    {
        #region Private Methods
        private RecentlyUsedList<string> _recentlyUsedList;
        private int _size;
        #endregion
        #region Setup/TearDown
        [TestFixtureSetUp]
        public void Setup()
        {
            _recentlyUsedList = new RecentlyUsedList<string>();
            _size = 10;
        }
        [TestFixtureTearDown]
        public void TearDown()
        {
            _recentlyUsedList = null;
            _size = -1;
        }


        #endregion
        [Test]
        public void CanAddItems()
        {
            _recentlyUsedList.Add("FirstList");
            var listCount = _recentlyUsedList.ToList().Count;
            Assert.That(listCount, Is.GreaterThan(0), string.Format("List items count should be Greater than {0} but is {1}", 0, listCount));

        }
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

        [Test]
        public void CanTestDefaultListSize()
        {
            const int expectedlistSize = 5;
            var actuallistsize = _recentlyUsedList.Size;
            Assert.That(actuallistsize, Is.EqualTo(expectedlistSize));
        }

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

            Assert.That(exception.Message, Is.EqualTo(string.Format("supplied index [{0}] should not be greater than [{1}].", index, _recentlyUsedList.Count - 1)));
        }

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

        }

        #region Private Methods
        private List<string> ToList(params string[] items)
        {
            return items.ToList();
        }

        #endregion

    }
}
