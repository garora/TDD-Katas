using NUnit.Framework;

namespace TDD_Katas_project.StringSum
{
    [TestFixture]
    [Category("StringSumkata")]
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
