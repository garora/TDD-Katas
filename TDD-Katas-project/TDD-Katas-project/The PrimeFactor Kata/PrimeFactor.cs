using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_Katas_project.The_PrimeFactor_Kata
{
    public class PrimeFactor
    {
        public static IList<int?> Generate(int n)
        {
            IList<int?> primes = new List<int?>();
            if (n > 1)
                primes.Add(2);
            return primes;
        }


    }
}
