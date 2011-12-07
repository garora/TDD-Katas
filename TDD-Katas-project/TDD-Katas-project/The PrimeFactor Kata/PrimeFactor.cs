using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_Katas_project.The_PrimeFactor_Kata
{
    public class PrimeFactor
    {
        public static IList<int?> Generate(int number)
        {
            IList<int?> primes = new List<int?>();
            if (number > 1)
            {
                if (number%2 == 0)
                {
                    primes.Add(2);
                    number /= 2;
                }
                if(number>1)
                    primes.Add(number);
            }
            return primes;
        }


    }
}
