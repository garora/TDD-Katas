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
                var primenumber = IsPrimeNumber(number) ? Convert.ToString(number) : oddNumber;
                if (!string.IsNullOrEmpty(newNumber))
                    newNumber += IsEvenNumber(number) ? "Even" : primenumber;
                else
                {
                    newNumber = IsEvenNumber(number) ? "Even" : primenumber;
                }
                result += newNumber;
            }
            return result;
        }
        private static bool IsEvenNumber(int number)
        {
            return number > 2 && number % 2 == 0;
        }
        private static bool IsOddNumber(int number)
        {
            return (number % 2 != 0);
        }
        private static bool IsPrimeNumber(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (IsEvenNumber(number)) return false;
            var divisble = 3;
            while (divisble * divisble <= number)
            {
                if (number % divisble == 0) return false;
                divisble += 2;
            }
            return true;

        }
    }
}
