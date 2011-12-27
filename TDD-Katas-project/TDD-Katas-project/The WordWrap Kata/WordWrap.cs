using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_Katas_project.The_WordWrap_Kata
{
    public class WordWrap
    {
        public static string Wrap(string word, int wordLength)
        {
            var actualCount = 0;
            var wrappedword = string.Empty;
            if (!IsContainNullEmptyOrWhiteSpaces(word))
            {
                foreach (var wrd in word)
                {
                    wrappedword = wrappedword + Convert.ToString(wrd);
                    if (IsWhiteSpaceOrNewLine(wrd)) continue;

                    actualCount++;

                    if (actualCount == wordLength)
                        wrappedword += "\n";
                }
            }

            else
                wrappedword = string.Empty;

            return wrappedword;
        }


        private static bool IsContainNullEmptyOrWhiteSpaces(string word)
        {
            return (string.IsNullOrEmpty(word)) || (string.IsNullOrWhiteSpace(word));
        }

        private static bool IsWhiteSpaceOrNewLine(char wrd)
        {
            return char.IsWhiteSpace(wrd) && (wrd == '\n');
        }
    }
}
