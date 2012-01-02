using System.Linq;
using NUnit.Framework;
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
            _size = -1; //empty list
        }


        #endregion
        [Test]
        public void CanAddItems()
        {
            var listCount = _recentlyUsedList.ToList().Count;
            Assert.That(listCount, Is.GreaterThan(0), string.Format("List items count should be Greater than {0} but is {1}", 0, listCount));

        }
    }
}
