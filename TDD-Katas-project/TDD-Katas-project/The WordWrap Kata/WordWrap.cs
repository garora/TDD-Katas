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
            foreach (var wrd in word)
            {
                wrappedword = wrappedword + Convert.ToString(wrd);
                if (!char.IsWhiteSpace(wrd) || (wrd != '\n'))
                {
                    actualCount++;
                    if (actualCount == wordLength)
                        wrappedword += "\n";
                }
            }
            return wrappedword;
        }
    }
}
