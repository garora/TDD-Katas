// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using System.Reactive.Linq;

namespace TDD_Katas_project.FizzBuzzKata.Rx
{
    /// <summary>
    /// Added a different implementation for FizzBuzz using Reactive extensions.
    /// The changes are described at: http://blog.drorhelper.com/2015/02/fizzbuzz-tdd-kata-using-reactive.html
    /// Pull Request by: https://github.com/dhelper
    /// These changes have been manually merged into repository
    /// </summary>
    public class FizzBuzzRx
    {
        public static string Generate(int max)
        {
            var result = string.Empty;
            if (max <= 0)
            {
                return result;
            }

            var observable = Observable.Range(1, max);

            var dividedByThree = observable
                .Where(i => i % 3 == 0)
                .Select(_ => "Fizz");

            var dividedByFive = observable
                .Where(i => i % 5 == 0)
                .Select(_ => "Buzz");

            var simpleNumbers = observable
               .Where(i => i % 3 != 0 && i % 5 != 0)
               .Select(i => i.ToString());

            var commaDelimiter = observable.Select(_ => ",");

            IObservable<string> specialCases = (dividedByThree).Merge(dividedByFive);
            simpleNumbers
                .Merge(specialCases)
                .Merge(commaDelimiter)
                .Subscribe(s => result += s);

            return result;
        }
    }
}