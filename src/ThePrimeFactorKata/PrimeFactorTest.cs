// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace TDD_Katas_project.ThePrimeFactorKata
{
    /// <summary>
    /// Prime Factor Tests
    /// </summary>
    [TestFixture]
    [Category("The PrimeFactor Kata")]
    public class PrimeFactorTest
    {
        private static IList<int?> List(params int[] ints) => ints.Select(i => (int?)i).ToList();
        /// <summary>
        /// Testones this instance.
        /// </summary>
        [Test]
        public void Testone() => Assert.That(List(), Is.EqualTo(PrimeFactor.Generate(1)));
        /// <summary>
        /// Testwoes this instance.
        /// </summary>
        [Test]
        public void Testwo() => Assert.That(List(2), Is.EqualTo(PrimeFactor.Generate(2)));
        /// <summary>
        /// Testhrees this instance.
        /// </summary>
        [Test]
        public void Testhree() => Assert.That(List(3), Is.EqualTo(PrimeFactor.Generate(3)));
        /// <summary>
        /// Tesfours this instance.
        /// </summary>
        [Test]
        public void Tesfour() => Assert.That(List(2, 2), Is.EqualTo(PrimeFactor.Generate(4)));
        /// <summary>
        /// Tests the six.
        /// </summary>
        [Test]
        public void TestSix() => Assert.That(List(2, 3), Is.EqualTo(PrimeFactor.Generate(6)));
        /// <summary>
        /// Tests the eight.
        /// </summary>
        [Test]
        public void TestEight() => Assert.That(List(2, 2, 2), Is.EqualTo(PrimeFactor.Generate(8)));
        /// <summary>
        /// Tests the nine.
        /// </summary>
        [Test]
        public void TestNine() => Assert.That(List(3, 3), Is.EqualTo(PrimeFactor.Generate(9)));
    }
}
