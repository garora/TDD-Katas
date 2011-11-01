using System;
using System.Linq;

namespace TDD_Katas_project.StringCalculator
{
    public class Calculator
    {
        public static int Add(string numbers)
        {
            return string.IsNullOrEmpty(numbers) ? 0 : GetSum(numbers);
        }

        private static int GetSum(string numbers)
        {
            var delimiter = GetPossibleDelimiter(numbers);
            var number = numbers.Split(delimiter.ToCharArray());
            var sum = number.Sum(n => ParseToInt(n));
            return sum;
        }

        private static string GetPossibleDelimiter(string numbers)
        {
            return numbers.Contains("\n") ? "\n" : ",";
        }

        private static int ParseToInt(string n)
        {
            var number = 0;
            if (ContainsAny(n, GetPossibleDelimiter(n)))
                number = Convert.ToInt32(n.Remove(n.IndexOf(GetPossibleDelimiter(n)), 0));

            var result = Convert.ToInt32(string.IsNullOrEmpty(n) ? "0" : n);

            VelidateNumbersArePerRule(result);

            return result;
        }

        private static bool ContainsAny(string input, string getPossibleDelimiters)
        {
            return getPossibleDelimiters.ToCharArray().Any(input.Contains);
        }

        private static void VelidateNumbersArePerRule(int number)
        {
            if (number < 0)
                throw new ArgumentException(string.Format("string contains [{0}], which does not meet rule. entered number should not negative.", number));
        }
    }
}
