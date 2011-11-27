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
                    newNumber += string.Format("{0}\r", number % 2 == 0 ? "Even" : Convert.ToString(number));
                else
                {
                    newNumber = number%2==0 ? "Even" : Convert.ToString(number);
                }
                result += newNumber;
            }
            return result;
        }
    }
}
