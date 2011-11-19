using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TDD_Katas_project.FizzBuzzKata
{
    public class FizzBuzz
    {
        public static string PrintFizzBuzz()
        {
            var resultFizzBuzz = string.Empty;
            resultFizzBuzz = GetNumbers(resultFizzBuzz);
            return resultFizzBuzz;
        }
        public static string PrintFizzBuzz(int number)
        {
            CanThrowArgumentExceptionWhenNumberNotInRule(number);
            var result = number.ToString();
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
                    printNumber = (i).ToString();
                resultFizzBuzz += " " + printNumber;
            }
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
    }
}
