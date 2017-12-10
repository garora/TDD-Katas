// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Text;

namespace TDD_Katas_NETCore.LCDDigits
{
    internal class LCDDigits
    {
        private static readonly int DIGIT_HEIGHT_DIMENSION = 1;

        private static readonly string[,] LcdDigitsMap =
        {
            {
                "._.",
                "|.|",
                "|_|"
            },
            {
                "...",
                "..|",
                "..|"
            },
            {
                "._.",
                "._|",
                "|_."
            },
            {
                "._.",
                "._|",
                "._|"
            },
            {
                "...",
                "|_|",
                "..|"
            },
            {
                "._.",
                "|_. ",
                "._|"
            },
            {
                "._.",
                "|_.",
                "|_|"
            },
            {
                "._.",
                "..|",
                "..|"
            },
            {
                "._.",
                "|_|",
                "|_|"
            },
            {
                "._.",
                "|_|",
                "..|"
            }
        };


        internal static string GetDigits(int number)
        {
            var output = new StringBuilder();
            var numberArray = ConvertIntegerToArray(number);

            for (var digitHeight = 0; digitHeight < LcdDigitsMap.GetLength(DIGIT_HEIGHT_DIMENSION); digitHeight++)
            {
                for (var numberIndex = 0; numberIndex < numberArray.Length; numberIndex++)
                    output.Append(
                        GetDigitLine(ConvertCharArrayToInteger(numberArray, numberIndex),
                            digitHeight));

                output.AppendLine();
            }

            return output.ToString();
        }

        private static int ConvertCharArrayToInteger(char[] numberArray, int numberIndex) => (int) char.GetNumericValue(numberArray[numberIndex]);

        private static string GetDigitLine(int number, int digitHeight) => LcdDigitsMap[number, digitHeight];

        private static char[] ConvertIntegerToArray(int number) => number.ToString().ToCharArray();
    }
}