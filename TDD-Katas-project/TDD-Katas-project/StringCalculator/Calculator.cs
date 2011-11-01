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
            string[] number = { };
            var sum = 0;
            var newnumbers = numbers;
            var specificnumber = string.Empty;
            if (numbers.StartsWith("//")) //for specific delimiters
            {
                delimiter = GetSpecificDelimiter(numbers);
                newnumbers = GetSpecificNumbers(numbers);
                 
                
            }

            number = newnumbers.Split(delimiter.ToCharArray());
            if (ContainsAny(numbers, delimiter))
                sum = number.Sum(n => ParseToInt(n));
            else
                sum = ParseToInt(newnumbers);
               
            return sum;
        }

        private static string GetPossibleDelimiter(string numbers)
        {
            return ",\n";
        }
        private static string GetSpecificDelimiter(string numbers)
        {
            return numbers.Substring(2, numbers.IndexOf("\n") - 2);
        }
        private static string GetSpecificNumbers(string numbers)
        {
            return numbers.Substring(numbers.IndexOf("\n") + 1, numbers.Length - numbers.IndexOf("\n") - 1);
        }
        private static int ParseToInt(string n)
        {
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
