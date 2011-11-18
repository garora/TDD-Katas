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
            var ResultFizzBuzz = string.Empty;
            ResultFizzBuzz = GetNumbers(ResultFizzBuzz);
            return ResultFizzBuzz;
        }

        private static string GetNumbers(string ResultFizzBuzz)
        {
            for (int i = 1; i <= 100; i++)
            {
                var printNumber = string.Empty;
                if (IsFizz(i)) printNumber += "Fizz";
                if (IsBuzz(i)) printNumber += "Buzz";
                if (IsNumber(printNumber))
                    printNumber = (i).ToString();
                ResultFizzBuzz +=" "+ printNumber;
            }
            return ResultFizzBuzz.Trim();
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
