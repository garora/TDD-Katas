using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Refere : http://osherove.com/tdd-kata-1/ of String Calculator exercise - detail is in StringCalculator.txt
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
            var sum = 0;
            if (number.Length > 0)
            {
                sum = number.Sum(n => ParseToInt(n));
            }
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
            if (number < 0 || number > 3)
                throw new ArgumentException(string.Format("string contains [{0}], which does not meet rule. enter numbers between [0-3]", number));
        }
    }
}
