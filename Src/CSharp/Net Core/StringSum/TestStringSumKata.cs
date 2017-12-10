// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.

using NUnit.Framework;

namespace TDD_Katas_NETCore.StringSum
{
    [TestFixture]
    [Category("StringSumkata NET Core")]
    public class TestStringSumKata
    {
        [TestCase("", null, "0")]
        [Test]
        public void AddReturnSum(string num1, string num2, string expectedResult)
        {
            var result = StringSumKata.Sum(num1, num2);

            Assert.That(expectedResult, Is.EqualTo(result));
        }
    }
}
