#region Description of Kara - Recently Used List
//Recently Used List :

//    Develop a recently-used-list class to hold strings 
//    uniquely in Last-In-First-Out order.

//    o) The most recently added item is first, the least
//       recently added item is last.

//    o) Items can be looked up by index, which counts from zero.

//    o) Items in the list are unique, so duplicate insertions
//       are moved rather than added.

//    o) A recently-used-list is initially empty.

//    Optional extras

//    o) Null insertions (empty strings) are not allowed.

//    o) A bounded capacity can be specified, so there is an upper
//       limit to the number of items contained, with the least
//       recently added items dropped on overflow.
#endregion

using System;
using System.Collections;
using System.Collections.Generic;

namespace TDD_Katas_project.The_RecentlyUsedList_kata
{
    public class RecentlyUsedList<T> : IEnumerable<T>
    {
        private List<T> _listofuniquestrings;
        private int _listSize;

        public RecentlyUsedList()
        {
            _listofuniquestrings = new List<T>();
        }
        public RecentlyUsedList(int listSize)
        {
            _listofuniquestrings = new List<T>();
            _listSize = listSize;
        }
        #region Implementation of IEnumerable

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
