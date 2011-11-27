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
                var oddNumber = IsOddNumber(number) ? "Odd" : Convert.ToString(number);
                if (!string.IsNullOrEmpty(newNumber))
                    newNumber += IsEvenNumber(number) ? "Even" : oddNumber;
                else
                {
                    newNumber = IsEvenNumber(number) ? "Even" : oddNumber;
                }
                result += newNumber;
            }
            return result;
        }
        private static bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }
        private static bool IsOddNumber(int number)
        {
            return (number % 2 != 0);
        }
        private static bool IsPrimeNumber(int number)
        {
            return number%number == 0;
        }
    }
}
