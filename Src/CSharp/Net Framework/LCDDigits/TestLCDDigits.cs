// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using NUnit.Framework;
using System;


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

namespace TDD_Katas_project.LCDDigits
{
    [TestFixture]
    [Category("LCDDigits Kata")]
    public class TestLCDDigits
    {
        [Test]
        public void digit_the_number_0()
        {
            string expect = "._." + "\r\n" +
                            "|.|" + "\r\n" +
                            "|_|" + "\r\n";

            Assert.That(LCDDigits.getDigits(0), Is.EqualTo(expect));
        }

        [Test]
        public void digit_the_number_1()
        {
            string expect = "..." + "\r\n" +
                            "..|" + "\r\n" +
                            "..|" + "\r\n";

            Assert.That(LCDDigits.getDigits(1), Is.EqualTo(expect));
        }

        [Test]
        public void digit_the_number_10()
        {
            string expect = "..." + "._." + "\r\n" +
                            "..|" + "|.|" + "\r\n" +
                            "..|" + "|_|" + "\r\n";

            Assert.That(LCDDigits.getDigits(10), Is.EqualTo(expect));
        }

        [Test]
        public void digit_the_number_100()
        {
            string expect = "..." + "._." + "._." + "\r\n" +
                            "..|" + "|.|" + "|.|" + "\r\n" +
                            "..|" + "|_|" + "|_|" + "\r\n";

            Assert.That(LCDDigits.getDigits(100), Is.EqualTo(expect));
        }
    }
}
