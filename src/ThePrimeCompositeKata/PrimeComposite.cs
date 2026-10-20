// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System.Collections.Generic;

namespace TDD_Katas_project.ThePrimeCompositeKata
{
    /// <summary>
    /// Labels prime numbers, odd composite numbers, and all other numbers.
    /// </summary>
    public class PrimeComposite
    {
        /// <summary>
        /// Returns "Prime" for primes, "Composite" for odd composites, and the
        /// number itself otherwise.
        /// </summary>
        public static string Classify(int number)
        {
            if (IsPrime(number))
                return "Prime";

            if (number > 1 && number % 2 != 0)
                return "Composite";

            return number.ToString();
        }

        /// <summary>Classifies every number in the inclusive range, separated by spaces.</summary>
        public static string PrintRange(int startNumber, int endNumber)
        {
            if (startNumber > endNumber)
                return string.Empty;

            var results = new List<string>();
            for (var number = startNumber; ; number++)
            {
                results.Add(Classify(number));
                if (number == endNumber)
                    break;
            }

            return string.Join(" ", results);
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (var divisor = 2; divisor <= number / divisor; divisor++)
                if (number % divisor == 0)
                    return false;

            return true;
        }
    }
}
