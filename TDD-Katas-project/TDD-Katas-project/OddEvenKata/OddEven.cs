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
                    newNumber += string.Format("{0} ", IsEvenNumber(number) ? "Even" : "Odd");
                else
                {
                    newNumber = IsEvenNumber(number) ? "Even" : "Odd";
                }
                result += newNumber;
            }
            return result;
        }
        private static bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }
    }
}
