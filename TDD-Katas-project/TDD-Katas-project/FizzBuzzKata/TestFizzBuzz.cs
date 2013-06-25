﻿using System;
using NUnit.Framework;

namespace TDD_Katas_project.FizzBuzzKata
{
    [TestFixture]
    [Category("TheFizzBuzzKata")]
    public class TestFizzBuzz
    {
        #region Private members
        //private string _result;
        private string _resultFizz;
        #endregion

        #region Setup/TearDown
        [TestFixtureSetUp]
        public void Setup()
        {
            //_result = @"1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40 41 42 43 44 45 46 47 48 49 50 51 52 53 54 55 56 57 58 59 60 61 62 63 64 65 66 67 68 69 70 71 72 73 74 75 76 77 78 79 80 81 82 83 84 85 86 87 88 89 90 91 92 93 94 95 96 97 98 99 100";
            _resultFizz = @"1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz";
        }
        [TestFixtureTearDown]
        public void TearDown()
        {
            //_result = null;
            _resultFizz = null;
        }
        #endregion

        #region Test Methods

        //[Test]
        //[Ignore]
        //public void CanTestFizzBuzz()
        //{
        //    Console.WriteLine(FizzBuzz.PrintFizzBuzz());
        //    Assert.That(_result, Is.EqualTo(FizzBuzz.PrintFizzBuzz()));
        //}
        [Test]
        public void CanTestFizz()
        {
            Console.WriteLine(FizzBuzz.PrintFizzBuzz());
            Assert.That(FizzBuzz.PrintFizzBuzz(), Is.EqualTo(_resultFizz));
        }
        [Test]
        [TestCase(-1)]
        [TestCase(101)]
        [TestCase(0)]
        public void CanThrowArgumentExceptionWhenSuppliedNumberDoesNotMeetRule(int number)
        {
            var exception = Assert.Throws<ArgumentException>(() => FizzBuzz.PrintFizzBuzz(number));

            Assert.That(exception.Message, Is.EqualTo(string.Format("entered number is [{0}], which does not meet rule, entered number should be between 1 to 100.", number)));

        }
        [Test]
        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        public void CanTestSingleNumber(int number, string expectedresult)
        {
            var actualresult = FizzBuzz.PrintFizzBuzz(number);
            Assert.That(actualresult, Is.EqualTo(expectedresult),
                             string.Format("result of entered number [{0}] is [{1}] but it should be [{2}]", number,
                                           actualresult, expectedresult));
        }
        #endregion
    }
}

