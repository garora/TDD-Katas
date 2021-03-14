// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using NUnit.Framework;

namespace TDD_Katas_project.TheWordWrapKata
{
    /// <summary>
    /// The Word Wrap Kata
    /// </summary>
    [TestFixture]
    [Category("The Word Wrap Kata")]
    public class WordWrapTest
    {
        /// <summary>
        /// Determines whether this instance [can wrap single line].
        /// </summary>
        [Test]
        public void CanWrapSingleLine() => Assert.That("Let's\nGo", Is.EqualTo(WordWrap.Wrap("Let's  Go", 5)));
        /// <summary>
        /// Determines whether this instance [can test for null word].
        /// </summary>
        [Test]
        public void CanTestForNullWord() => Assert.That("", Is.EqualTo(WordWrap.Wrap(null, 5)));
        /// <summary>
        /// Determines whether this instance [can test for null or white spaces word].
        /// </summary>
        [Test]
        public void CanTestForNullOrWhiteSpacesWord()
        {
            Assert.That("", Is.EqualTo(WordWrap.Wrap(null, 5)));
            Assert.That("", Is.EqualTo(WordWrap.Wrap(" ", 5)));
        }
        /// <summary>
        /// Determines whether this instance [can test new line character].
        /// </summary>
        [Test]
        public void CanTestNewLineCharacter()
        {
            Assert.That("\n", Is.EqualTo(WordWrap.Wrap("\n", 1)));
            Assert.That("\nLet's\nGo\noutside.", Is.EqualTo(WordWrap.Wrap("\nLet's Go\noutside.", 5)));
        }
        /// <summary>
        /// Determines whether this instance [can wrap multiple line].
        /// </summary>
        [Test]
        public void CanWrapMultipleLine()
        {
            const string inputword = "Today is friday. \nLets go outside.\n Happy weekedn!";
            const string expectedword = "Today\n is friday. \nLets go outside.\nHappy weekedn!";
            var actualresult = (WordWrap.Wrap(inputword, 5));
            Assert.That(expectedword, Is.EqualTo(actualresult),
                       string.Format("result of entered word [{0}] is [{1}] but it should be [{2}]", inputword,
                                     actualresult, expectedword));
        }
    }
}
