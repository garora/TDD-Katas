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
using System.Linq;

namespace TDD_Katas_project.The_RecentlyUsedList_kata
{
    public class RecentlyUsedList<T> : IEnumerable<T>
    {
        #region Private members

        private List<T> _listofuniquestrings;
        private int _listSize = -1;

        #endregion

        #region Class Initializers

        public RecentlyUsedList()
        {
            _listofuniquestrings = new List<T>();
        }
        public RecentlyUsedList(int listSize)
        {
            _listofuniquestrings = new List<T>();
            _listSize = listSize;
        }

        public RecentlyUsedList(IEnumerable<T> listItems)
        {
            _listofuniquestrings = listItems.ToList();
        }

        public RecentlyUsedList(int listSize, IEnumerable<T> listItems)
        {
            _listofuniquestrings = listItems.ToList();
            _listSize = listSize;

            if (_listSize != -1)

                while (_listofuniquestrings.Count > _listSize)

                    _listofuniquestrings.RemoveAt(_listofuniquestrings.Count - 1);
        }
        #endregion

        #region Helper Methods
        public int Count
        {

            get
            {
                return _listofuniquestrings != null ? _listofuniquestrings.Count : 0;
            }
        }
        #endregion

        #region Implementation of IEnumerable

        public IEnumerator<T> GetEnumerator()
        {
            return _listofuniquestrings.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _listofuniquestrings.GetEnumerator();
        }

        #endregion

    }



}
