// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using System.Globalization;

namespace TDD_Katas_project.TheWordWrapKata
{
    public class WordWrap
    {
        #region Public Methods
        public static string Wrap(string word, int wordLength)
        {
            var actualCount = 0;
            var wrappedword = string.Empty;

            if (IsContainNewLine(word)) return word;

            if (IsContainNullEmptyOrWhiteSpaces(word)) return string.Empty;

            foreach (var wrd in word)
            {
                wrappedword = wrappedword + Convert.ToString(wrd);

                if (IsWhiteSpaceOrNewLine(wrd)) continue;

                if (IsContainNewLine(wrd.ToString(CultureInfo.InvariantCulture))) continue;

                actualCount++;

                if (actualCount == wordLength)
                    wrappedword += "\n";
            }

            wrappedword = GetWrappedwordWithoutBlankSpacesAtStartOfNewLine(wrappedword);

            return wrappedword;
        }
        #endregion

        #region MyRegion
        
        private static string GetWrappedwordWithoutBlankSpacesAtStartOfNewLine(string wrappedword)
        {
            var newWrappedWord = wrappedword;
            var spaceCounter = 0;
            
            for (var outCounter = 0; outCounter < wrappedword.Length; outCounter++)
            {
                if (IsContainNewLine(wrappedword[outCounter].ToString(CultureInfo.InvariantCulture)))
                    for (var inCounter = outCounter + 1; inCounter < wrappedword.Length; inCounter++)
                    {
                        if (char.IsWhiteSpace(wrappedword[inCounter]))
                            spaceCounter++;
                        else
                            break;
                    }
                
                if (spaceCounter <= 0) continue;

                newWrappedWord = RemoveWhiteSpacesFromWrappedWord(wrappedword, outCounter, spaceCounter); //RemoveWhiteSpacesFromWrappedWord(wrappedword, outCounter + 1, spaceCounter);

                spaceCounter = 0;
            }

            return newWrappedWord;
        }

        private static string RemoveWhiteSpacesFromWrappedWord(string wrappedword, int outCounter, int spaceCounter)
        {
            return wrappedword.Remove(outCounter + 1, spaceCounter);
        }

        private static bool IsContainNewLine(string word)
        {
            return word == "\n";
        }

        private static bool IsContainNullEmptyOrWhiteSpaces(string word)
        {
            return (string.IsNullOrEmpty(word)) || (string.IsNullOrWhiteSpace(word));
        }

        private static bool IsWhiteSpaceOrNewLine(char wrd)
        {
            return char.IsWhiteSpace(wrd) && (wrd == '\n');
        }
        
        #endregion
    }
}
