// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace TDD_Katas_NETCore.ThePrimeFactorKata
{
    public class PrimeFactor
    {
        public static IList<int?> Generate(int number)
        {
            IList<int?> primes = new List<int?>();

            for (var candidate = 2; number > 1; candidate++)
            for (; number % candidate == 0; number /= candidate)
                primes.Add(candidate);

            return primes;
        }
    }
}