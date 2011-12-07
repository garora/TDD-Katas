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
            int candidate = 2;
            while (number > 1)
            {
                while (number % candidate == 0)
                {
                    primes.Add(candidate);
                    number /= candidate;
                }
                candidate++;
            }

            return primes;
        }


    }
}
