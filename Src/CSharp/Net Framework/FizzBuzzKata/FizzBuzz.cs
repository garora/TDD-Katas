// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using System.Globalization;
using System.Linq;

namespace TDD_Katas_project.FizzBuzzKata
{
    public class FizzBuzz
    {
        #region Public Methods


        public static string PrintFizzBuzz()
        {
            var resultFizzBuzz = string.Empty;
            resultFizzBuzz = GetNumbers(resultFizzBuzz);
            return resultFizzBuzz;
        }
        public static string PrintFizzBuzz(int number)
        {
            CanThrowArgumentExceptionWhenNumberNotInRule(number);

            var result = GetFizzBuzzResult(number);

            if (string.IsNullOrEmpty(result))
                result = GetFizzResult(number);
            if (string.IsNullOrEmpty(result))
                result = GetBuzzResult(number);

            return string.IsNullOrEmpty(result) ? number.ToString(CultureInfo.InvariantCulture) : result;
        }
        #endregion

        #region Private Methods
        private static string GetFizzBuzzResult(int number)
        {
            string result = null;
            if (IsFizz(number) && IsBuzz(number)) result = "FizzBuzz";
            return result;
        }

        private static string GetBuzzResult(int number)
        {
            string result = null;
            if (IsBuzz(number)) result = "Buzz";
            return result;
        }

        private static string GetFizzResult(int number)
        {
            string result = null;
            if (IsFizz(number)) result = "Fizz";
            return result;
        }

        private static void CanThrowArgumentExceptionWhenNumberNotInRule(int number)
        {
            if (number > 100 || number < 1)
                throw new ArgumentException(
                    string.Format(
                        "entered number is [{0}], which does not meet rule, entered number should be between 1 to 100.", number));
        }

        private static string GetNumbers(string resultFizzBuzz)
        {

            for (var i = 1; i <= 100; i++)
            {
                var printNumber = string.Empty;
                if (IsFizz(i)) printNumber += "Fizz";
                if (IsBuzz(i)) printNumber += "Buzz";
                if (IsNumber(printNumber))
                    printNumber = (i).ToString(CultureInfo.InvariantCulture);
                resultFizzBuzz += " " + printNumber;
            }
            return resultFizzBuzz.Trim();
        }
        private static string GetNumbersUsingLinq(string resultFizzBuzz)
        {
            Enumerable.Range(1, 100)
                .Select(fb => String.Format("{0}{1}", fb % 3 == 0 ? "Fizz" : "", fb % 5 == 0 ? "Buzz" : ""))
                .Select(fb => fb != null ? (String.IsNullOrEmpty(fb) ? fb.ToString(CultureInfo.InvariantCulture) : fb) : null)
                .ToList()
                .ForEach(x => resultFizzBuzz = x);
            return resultFizzBuzz.Trim();
        }

        private static bool IsNumber(string printNumber)
        {
            return String.IsNullOrEmpty(printNumber);
        }

        private static bool IsBuzz(int i)
        {
            return i % 5 == 0;
        }

        private static bool IsFizz(int i)
        {
            return i % 3 == 0;
        }
        #endregion
    }
}
