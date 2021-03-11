// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using System.Text;

namespace TDD_Katas_project.Common.Utility
{
    /// <summary>
    /// SimpleNaturalStringOrder
    /// </summary>
    /// <seealso cref="System.IComparable" />
    /// <seealso cref="System.IDisposable" />
    public class SimpleNaturalStringOrder : IComparable, IDisposable
    {
        bool _disposed;
        /// <summary>
        /// Gets or sets the item value.
        /// </summary>
        /// <value>
        /// The item value.
        /// </value>
        public string ItemValue { get; set; }
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString() => ItemValue;
        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="compareObject">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object compareObject)
        {
            if (compareObject == null && ItemValue == null)
                return true;

            return compareObject != null && ItemValue.Equals(compareObject.ToString());
        }
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode() => ItemValue.GetHashCode();
        /// <summary>
        /// Finalizes an instance of the <see cref="SimpleNaturalStringOrder"/> class.
        /// </summary>
        ~SimpleNaturalStringOrder() => Dispose(false);

        #region IDisposable Members        
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="bDisposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool bDisposing)
        {
            if (!_disposed)
            {
                _disposed = true;
            }
        }

        #endregion

        #region Enumerations
        private enum CharType { Alphanumeric, Numeric }
        #endregion

        #region IComparable Members        
        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value has these meanings:
        /// <list type="table"><listheader><term> Value</term><description> Meaning</description></listheader><item><term> Less than zero</term><description> This instance precedes <paramref name="obj" /> in the sort order.</description></item><item><term> Zero</term><description> This instance occurs in the same position in the sort order as <paramref name="obj" />.</description></item><item><term> Greater than zero</term><description> This instance follows <paramref name="obj" /> in the sort order.</description></item></list>
        /// </returns>
        public int CompareTo(object obj)
        {
            string firstStringToCompare = ItemValue
                , secondStringToCompare = Convert.ToString(obj);

            if (firstStringToCompare == null) { return 0; }

            var firstStringPosition = 0;
            var secondStringPosition = 0;

            while ((firstStringPosition < firstStringToCompare.Length)
                || (secondStringPosition < secondStringToCompare.Length))
            {
                if (firstStringPosition >= firstStringToCompare.Length) { return -1; }
                if (secondStringPosition >= secondStringToCompare.Length) { return 1; }

                var firstCharInString = firstStringToCompare[firstStringPosition];
                var secondCharInString = secondStringToCompare[secondStringPosition];

                var firstStringBuilder = new StringBuilder();
                var secondStringBuilder = new StringBuilder();

                StringChecks(firstStringToCompare, ref firstStringPosition, ref firstCharInString, firstStringBuilder);
                StringChecks(secondStringToCompare, ref secondStringPosition, ref secondCharInString, secondStringBuilder);

                var result = 0;

                if (char.IsDigit(firstStringBuilder[0])
                    && char.IsDigit(secondStringBuilder[0]))
                {
                    var firstNumericString = Convert.ToInt32(firstStringBuilder.ToString());
                    var secondNumericString = Convert.ToInt32(secondStringBuilder.ToString());

                    if (firstNumericString < secondNumericString) { result = -1; }
                    if (firstNumericString > secondNumericString) { result = 1; }
                }
                else { result = firstStringBuilder.ToString().CompareTo(secondStringBuilder.ToString()); }

                if (result != 0) { return result; }
            }

            return 0;
        }

        private bool InChar(char firstChar, char secondChar)
        {
            var charType = CharType.Alphanumeric;

            if (char.IsDigit(secondChar)) charType = CharType.Numeric;

            return (charType != CharType.Alphanumeric || !char.IsDigit(firstChar)) && (charType != CharType.Numeric || char.IsDigit(firstChar));
        }

        private void StringChecks(string stringToCompare, ref int stringPosition, ref char charInString, StringBuilder stringBuilder)
        {
            while ((stringPosition < stringToCompare.Length)
                && (stringBuilder.Length == 0 || InChar(charInString, stringBuilder[0])))
            {
                stringBuilder.Append(charInString);
                stringPosition++;

                if (stringPosition < stringToCompare.Length) { charInString = stringToCompare[stringPosition]; }
            }
        }

        #endregion

    }
}
