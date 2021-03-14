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
    /// <summary>
    /// RecentlyUsedList
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.Collections.Generic.IEnumerable{System.String}" />
    public class RecentlyUsedList<T> : IEnumerable<string>
    {
        private readonly List<string> _listofuniquestrings;
        private int _listSize = -1;
        private const int DefaultListSize = 5;

        /// <summary>
        /// Initializes a new instance of the <see cref="RecentlyUsedList{T}"/> class.
        /// </summary>
        public RecentlyUsedList()
        {
            _listofuniquestrings = new List<string>();
            SetDefaultListSize();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecentlyUsedList{T}"/> class.
        /// </summary>
        /// <param name="listSize">Size of the list.</param>
        public RecentlyUsedList(int listSize)
        {
            _listofuniquestrings = new List<string>();
            _listSize = listSize;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecentlyUsedList{T}"/> class.
        /// </summary>
        /// <param name="listItems">The list items.</param>
        public RecentlyUsedList(IEnumerable<string> listItems)
        {
            _listofuniquestrings = listItems.ToList();
            SetDefaultListSize();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecentlyUsedList{T}"/> class.
        /// </summary>
        /// <param name="listSize">Size of the list.</param>
        /// <param name="listItems">The list items.</param>
        public RecentlyUsedList(int listSize, IEnumerable<string> listItems)
        {
            _listofuniquestrings = listItems.ToList();
            _listSize = listSize;

            TrimListToTheSizeDefined();
        }

        /// <summary>
        /// Adds the specified listitem.
        /// </summary>
        /// <param name="listitem">The listitem.</param>
        /// <exception cref="ArgumentException"></exception>
        public void Add(string listitem)
        {
            if (string.IsNullOrEmpty(listitem))
                throw new ArgumentException(string.Format("List items should not be Empty or Null. But it was [{0}]",
                                                          listitem));
            AvoidDuplicateInsertion(listitem);

            _listofuniquestrings.Insert(0, listitem);

            TrimListToTheSizeDefined();

        }
        /// <summary>
        /// Gets the list item.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public string GetListItem(int index)
        {
            CheckForValidIndex(index);

            return _listofuniquestrings != null ? _listofuniquestrings[index] : string.Empty;
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count => _listofuniquestrings != null
            ? _listofuniquestrings.Count
            : 0;
        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public int Size => _listSize;
        /// <summary>
        /// Converts to list.
        /// </summary>
        /// <returns></returns>
        public List<string> ToList() => _listofuniquestrings;


        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// An enumerator that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<string> GetEnumerator() => _listofuniquestrings.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

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

    }
}