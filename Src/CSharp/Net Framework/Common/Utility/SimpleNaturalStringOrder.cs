// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using System.Text;

namespace TDD_Katas_project.Common.Utility
{
    public class SimpleNaturalStringOrder : IComparable, IDisposable
    {
        bool _disposed;
        public string ItemValue { get; set; }

        public override string ToString()
        { return ItemValue; }

        public override bool Equals(object compareObject)
        {
            if (compareObject == null && ItemValue == null)
                return true;

            return compareObject != null && ItemValue.Equals(compareObject.ToString());
        }

        public override int GetHashCode()
        {
            return ItemValue.GetHashCode();
        }

        ~SimpleNaturalStringOrder()
        {
            Dispose(false);
        }

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

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
