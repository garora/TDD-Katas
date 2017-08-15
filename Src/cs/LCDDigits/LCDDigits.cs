// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Katas_project.LCDDigits
{
    class LCDDigits
    {
        private static readonly int DIGIT_HEIGHT_DIMENSION = 1 ;
        private static readonly string[,] lcdDigitsMap = {
            {"._.",
             "|.|",
             "|_|" },
            {"...",
             "..|",
             "..|" },
            {"._.",
             "._|",
             "|_." },
            {"._.",
             "._|",
             "._|" },
            {"...",
             "|_|",
             "..|" },
            {"._.",
             "|_. ",
             "._|" },
            {"._.",
             "|_.",
             "|_|" },
            {"._.",
             "..|",
             "..|" },
            {"._.",
             "|_|",
             "|_|" },
            {"._.",
             "|_|",
             "..|" }
        };
              

        internal static string getDigits(int number)
        {
            var output = new StringBuilder();
            char[] numberArray = convertIntegerToArray(number);
            
            for (int digitHeight = 0; digitHeight < lcdDigitsMap.GetLength(DIGIT_HEIGHT_DIMENSION); digitHeight++)
            {
                for (int numberIndex = 0; numberIndex < numberArray.Length; numberIndex++)
                {
                    output.Append(
                        GetDigitLine(convertCharArrayToInteger(numberArray, numberIndex),
                        digitHeight));
                }
                
                output.AppendLine();
            }

            return output.ToString();
        }

        private static int convertCharArrayToInteger(char[] numberArray, int numberIndex)
        {
            return (int)Char.GetNumericValue(numberArray[numberIndex]);
        }

        private static string GetDigitLine(int number, int digitHeight)
        {
            return lcdDigitsMap[number, digitHeight];
        }

        private static char[] convertIntegerToArray(int number)
        {
            return number.ToString().ToCharArray();
        }
    }
}
