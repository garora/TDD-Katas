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
            var number = numbers.Split(','); //in first step we have only commas [,] as delimiter

            var sum = number.Sum(n => ParseToInt(n));
            return sum;
        }

        private static int ParseToInt(string n)
        {
            var result = Convert.ToInt32(string.IsNullOrEmpty(n) ? "0" : n);

            VelidateNumbersArePerRule(result);

            return result;
        }

        private static void VelidateNumbersArePerRule(int number)
        {
            if (number < 0)
                throw new ArgumentException(string.Format("string contains [{0}], which does not meet rule. entered number should not negative.", number));
        }
    }
}
