using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Katas_project.StringSum
{
    public class StringSumKata
    {
        public static string Sum(string num1, string num2)
        {
            var realNum1 = string.IsNullOrEmpty(num1) ? "0" : num1;
            var realNum2 = string.IsNullOrEmpty(num2) ? "0" : num2;

            return Convert.ToString(int.Parse(realNum1) + int.Parse(realNum2));
        }


    }
}
