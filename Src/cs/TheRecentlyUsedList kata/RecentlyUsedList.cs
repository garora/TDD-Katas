// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.

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

namespace TDD_Katas_project.TheRecentlyUsedList_kata
{
    public class RecentlyUsedList<T> : IEnumerable<string>
    {
        #region Private members

        private readonly List<string> _listofuniquestrings;
        private int _listSize = -1;
        private const int DefaultListSize = 5;

        #endregion

        #region Class Initializers

        public RecentlyUsedList()
        {
            _listofuniquestrings = new List<string>();
            SetDefaultListSize();
        }
        public RecentlyUsedList(int listSize)
        {
            _listofuniquestrings = new List<string>();
            _listSize = listSize;
        }

        public RecentlyUsedList(IEnumerable<string> listItems)
        {
            _listofuniquestrings = listItems.ToList();
            SetDefaultListSize();
        }

        public RecentlyUsedList(int listSize, IEnumerable<string> listItems)
        {
            _listofuniquestrings = listItems.ToList();
            _listSize = listSize;

            TrimListToTheSizeDefined();
        }
        #endregion

        #region Public methods
        public void Add(string listitem)
        {
            if (string.IsNullOrEmpty(listitem))
                throw new ArgumentException(string.Format("List items should not be Empty or Null. But it was [{0}]",
                                                          listitem));

            AvoidDuplicateInsertion(listitem);

            _listofuniquestrings.Insert(0, listitem);

            TrimListToTheSizeDefined();

        }

        public string GetListItem(int index)
        {
            CheckForValidIndex(index);

            return _listofuniquestrings != null ? _listofuniquestrings[index] : string.Empty;
        }


        #endregion

        #region Helper Methods /members

        public int Count
        {

            get
            {
                return _listofuniquestrings != null
                           ? _listofuniquestrings.Count
                           : 0;

            }
        }

        public int Size
        {

            get { return _listSize; }
        }

        public List<string> ToList()
        {
            return _listofuniquestrings;
        }
        #endregion

        #region Implementation of IEnumerable

        public IEnumerator<string> GetEnumerator()
        {
            return _listofuniquestrings.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        #region Private members
        private void SetDefaultListSize()
        {

            _listSize = _listSize < 0
                            ? DefaultListSize
                            : _listSize;

        }
        private void CheckForValidIndex(int index)
        {
            if (index < 0)
                throw new ArgumentException(string.Format("supplied index [{0}] should be non-negative and not greater than [{1}].", index, _listofuniquestrings.Count - 1));

            if (index > _listofuniquestrings.Count - 1)
                throw new ArgumentException(string.Format("supplied index [{0}] should not greater than [{1}].", index, _listofuniquestrings.Count - 1));
        }

        private void AvoidDuplicateInsertion(string listitem)
        {
            var indexOccurenceofItem = _listofuniquestrings.IndexOf(listitem);

            if (indexOccurenceofItem > -1)
                _listofuniquestrings.RemoveAt(indexOccurenceofItem);
        }

        private void TrimListToTheSizeDefined()
        {
            if (_listSize != -1)
                while (_listofuniquestrings.Count > _listSize)
                    _listofuniquestrings.RemoveAt(0); //Remove from Top in LIFO
        }

        #endregion

    }



}
