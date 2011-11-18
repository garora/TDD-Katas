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
                if (String.IsNullOrEmpty(printNumber))
                    printNumber = (i).ToString();
                ResultFizzBuzz +=" "+ printNumber;
            }
            return ResultFizzBuzz.Trim();
        }
        
        private static bool IsFizz(int i)
        {
            return i % 3 == 0;
        }
    }
}
