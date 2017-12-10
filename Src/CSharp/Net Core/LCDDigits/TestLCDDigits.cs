// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.

using NUnit.Framework;


/*
Your task is to create an LCD string representation of an
integer value using a 3x3 grid of space, underscore, and
pipe characters for each digit. Each digit is shown below
(using a dot instead of a space)

._.   ...   ._.   ._.   ...   ._.   ._.   ._.   ._.   ._.
|.|   ..|   ._|   ._|   |_|   |_.   |_.   ..|   |_|   |_|
|_|   ..|   |_.   ._|   ..|   ._|   |_|   ..|   |_|   ..|


Example: 910

._. ... ._.
|_| ..| |.|
..| ..| |_|

 */

namespace TDD_Katas_NETCore.LCDDigits
{
    [TestFixture]
    [Category("LCDDigits Kata NET Core")]
    public class TestLCDDigits
    {
        [Test]
        public void Digit_the_number_0()
        {
            const string expect = "._." + "\r\n" +
                                  "|.|" + "\r\n" +
                                  "|_|" + "\r\n";

            Assert.That(LCDDigits.GetDigits(0), Is.EqualTo(expect));
        }

        [Test]
        public void Digit_the_number_1()
        {
            const string expect = "..." + "\r\n" +
                                  "..|" + "\r\n" +
                                  "..|" + "\r\n";

            Assert.That(LCDDigits.GetDigits(1), Is.EqualTo(expect));
        }

        [Test]
        public void Digit_the_number_10()
        {
            const string expect = "..." + "._." + "\r\n" +
                                  "..|" + "|.|" + "\r\n" +
                                  "..|" + "|_|" + "\r\n";

            Assert.That(LCDDigits.GetDigits(10), Is.EqualTo(expect));
        }

        [Test]
        public void Digit_the_number_100()
        {
            const string expect = "..." + "._." + "._." + "\r\n" +
                                  "..|" + "|.|" + "|.|" + "\r\n" +
                                  "..|" + "|_|" + "|_|" + "\r\n";

            Assert.That(LCDDigits.GetDigits(100), Is.EqualTo(expect));
        }
    }
}