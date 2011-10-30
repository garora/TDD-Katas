using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
namespace TDD_Katas_project.StringCalculator
{
    [TestFixture]
    public class TestCalculator
    {
        [TestCase("")]
        [TestCase(null)]
        [Test]
        public void Add_ReturnZero_WhenSupplied_EmptyOrNullString(string numbers)
        {
            var result = Calculator.Add(numbers);
            Assert.That(result, Is.EqualTo(0));
        }
        [TestCase("0", 0)]
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("3", 3)]
        [Test]
        public void Add_ReturnNumber_WhenSuppliedSingleNumber_InString(string number, int expectedResult)
        {
            var result = Calculator.Add(number);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase("0,1",1)]
        [TestCase("0,1,1", 2)]
        [TestCase("0,2", 2)]
        [TestCase("0,2,2", 4)]
        [TestCase("0,3", 3)]
        [TestCase("0,3,2", 5)]
        [TestCase("0,3,3", 6)]
        [TestCase("0,3,2,", 5)]
        [Test]
        public void Add_ReturnSum_WhenSuppliedMultipleNumbers_InString(string numbers, int expectedResult)
        {
            var result = Calculator.Add(numbers);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [TestCase("1,4",4)]
        [Test]
        public void Add_ThrowArgumentException_WhenSuppliedString_DoesNot_Meet_Rule(string numbers,int beyondRule)
        {
            var exception = Assert.Throws<ArgumentException>(() => Calculator.Add(numbers));

            Assert.That(exception.Message, Is.EqualTo(string.Format("string contains [{0}], which does not meet rule. enter numbers between [0-3]", beyondRule)));

        }
    }
}
