using System;

namespace TDD_Katas_project.The_WordWrap_Kata
{
    public class WordWrap
    {
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
                if (IsContainNewLine(wrd.ToString())) continue;
                actualCount++;

                if (actualCount == wordLength)
                    wrappedword += "\n";

            }

            return wrappedword;
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
    }
}
