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

            wrappedword = GetWrappedwordWithoutBlankSpacesAtStartOfNewLine(wrappedword);
            return wrappedword;
        }

        private static string GetWrappedwordWithoutBlankSpacesAtStartOfNewLine(string wrappedword)
        {
            var newWrappedWord = wrappedword;
            var spaceCounter = 0;
            for (var outCounter = 0; outCounter < wrappedword.Length; outCounter++)
            {
                if (IsContainNewLine(wrappedword[outCounter].ToString()))
                    for (var inCounter = outCounter + 1; inCounter < wrappedword.Length; inCounter++)
                    {
                        if (char.IsWhiteSpace(wrappedword[inCounter]))
                            spaceCounter++;
                        if (IsContainNewLine(wrappedword[inCounter].ToString()))
                            break;
                    }
                if (spaceCounter <= 0) continue;
                newWrappedWord = wrappedword.Remove(outCounter + 1, spaceCounter);  //RemoveWhiteSpacesFromWrappedWord(wrappedword, outCounter + 1, spaceCounter);

                spaceCounter = 0;
            }
            return newWrappedWord;
        }

        private static string RemoveWhiteSpacesFromWrappedWord(string wrappedword, int inCounter, int spaceCount)
        {
            return wrappedword.Remove(inCounter, spaceCount);
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
