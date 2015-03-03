using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;

namespace TDD_Katas_project.FizzBuzzRxKata
{
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
