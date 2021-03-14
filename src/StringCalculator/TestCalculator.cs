// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using NUnit.Framework;
using System;

namespace TDD_Katas_project.StringCalculator
{
    /// <summary>
    /// Test Calculator
    /// </summary>
    [TestFixture]
    [Category("StringCalculatorKata")]
    public class TestCalculator
    {

        /// <summary>
        /// Adds the return zero when supplied empty or null string.
        /// </summary>
        /// <param name="numbers">The numbers.</param>
        [TestCase("")]
        [TestCase(null)]
        [Test]
        public void AddReturnZeroWhenSuppliedEmptyOrNullString(string numbers)
        {
            var result = Calculator.Add(numbers);
            Assert.That(result, Is.EqualTo(0));
        }
        /// <summary>
        /// Adds the return number when supplied single number in string.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="expectedResult">The expected result.</param>
        [TestCase("0", 0)]
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("3", 3)]
        [TestCase("0,1,2,3,4,555", 565)]
        [Test]
        public void AddReturnNumberWhenSuppliedSingleNumberInString(string number, int expectedResult)
        {
            var result = Calculator.Add(number);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        /// <summary>
        /// Adds the retur sum when supplied numbers in string with new line as delimiter.
        /// </summary>
        /// <param name="numbers">The numbers.</param>
        /// <param name="expectedResult">The expected result.</param>
        [TestCase("1,2,3", 6)]
        [TestCase("3\n2", 5)]
        [TestCase("1\n2,3", 6)]
        [TestCase("1\n2\n3,4,5", 15)]
        [Test]
        public void AddReturSumWhenSuppliedNumbersInStringWithNewLineAsDelimiter(string numbers, int expectedResult)
        {
            var result = Calculator.Add(numbers);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        /// <summary>
        /// Adds the return sum when supplied multiple numbers in string.
        /// </summary>
        /// <param name="numbers">The numbers.</param>
        /// <param name="expectedResult">The expected result.</param>
        [TestCase("0,1", 1)]
        [TestCase("0,1,1", 2)]
        [TestCase("0,2", 2)]
        [TestCase("0,2,2", 4)]
        [TestCase("0,3", 3)]
        [TestCase("0,3,2", 5)]
        [TestCase("0,3,3", 6)]
        [Test]
        public void AddReturnSumWhenSuppliedMultipleNumbersInString(string numbers, int expectedResult)
        {
            var result = Calculator.Add(numbers);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        /// <summary>
        /// Adds the return sum by ignoring more than thousand when supplied multiple numbers in string.
        /// </summary>
        /// <param name="numbers">The numbers.</param>
        /// <param name="expectedResult">The expected result.</param>
        [TestCase("0,3,1001", 3)]
        [TestCase("0,3,1000", 1003)]
        [Test]
        public void AddReturnSumByIgnoringMoreThanThousandWhenSuppliedMultipleNumbersInString(string numbers, int expectedResult)
        {
            var result = Calculator.Add(numbers);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        /// <summary>
        /// Adds the when given defined delimiter uses that delimiter.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="expectation">The expectation.</param>
        [TestCase("//*\n1*2", 3)]
        [TestCase("//;\n1;2", 3)]
        [TestCase("//;\n1;2;3;4;5;6;7;8;9;10", 55)]
        [Test]
        public void AddWhenGivenDefinedDelimiterUsesThatDelimiter(string input, int expectation)
        {
            var result = Calculator.Add(input);

            Assert.That(result, Is.EqualTo(expectation));
        }
        /// <summary>
        /// Adds the throw argument exception when supplied string does not meet rule.
        /// </summary>
        /// <param name="numbers">The numbers.</param>
        /// <param name="beyondRuleNumber">The beyond rule number.</param>
        [TestCase("1,-1", -1)]
        [Test]
        public void AddThrowArgumentExceptionWhenSuppliedStringDoesNotMeetRule(string numbers, int beyondRuleNumber)
        {
            var exception = Assert.Throws<ArgumentException>(() => Calculator.Add(numbers));

            Assert.That(exception.Message, Is.EqualTo(string.Format("string contains [{0}], which does not meet rule. entered number should not negative.", beyondRuleNumber)));

        }
    }
}