using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_Katas_project.OddEvenKata
{
    public class OddEven
    {
        public static string PrintOddEven()
        {
            var result = string.Empty;
            for (var number = 1; number <= 100; number++)
            {
                result += number;
            }
            return result;
        }

    }
}
