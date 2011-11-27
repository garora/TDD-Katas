using System;

namespace TDD_Katas_project.OddEvenKata
{
    public class OddEven
    {
        public static string PrintOddEven()
        {
            return GetOddEvenWithinRange();
        }

        private static string GetOddEvenWithinRange()
        {
            var result = string.Empty;
            for (var number = 1; number <= 100; number++)
            {
                var newNumber = string.Empty;
                if (!string.IsNullOrEmpty(newNumber))
                    newNumber += string.Format("{0}\r", GetEvenIfNumberDivisibleBy2(number));
                else
                {
                    newNumber = GetEvenIfNumberDivisibleBy2(number);
                }
                result += newNumber;
            }
            return result;
        }

        private static string GetEvenIfNumberDivisibleBy2(int number)
        {
            return number % 2 == 0 ? "Even" : Convert.ToString(number);
        }
    }
}
