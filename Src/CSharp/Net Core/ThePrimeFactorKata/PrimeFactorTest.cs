// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TDD_Katas_NETCore.ThePrimeFactorKata
{
    [TestFixture]
    [Category("The PrimeFactor Kata")]
    public class PrimeFactorTest
    {
        private static IList<int?> List(params int[] ints) => ints.Select(i => (int?) i).ToList();

        [Test]
        public void Tesfour()
        {
            Assert.That(List(2, 2), Is.EqualTo(PrimeFactor.Generate(4)));
        }

        [Test]
        public void TestEight()
        {
            Assert.That(List(2, 2, 2), Is.EqualTo(PrimeFactor.Generate(8)));
        }

        [Test]
        public void Testhree()
        {
            Assert.That(List(3), Is.EqualTo(PrimeFactor.Generate(3)));
        }

        [Test]
        public void TestNine()
        {
            Assert.That(List(3, 3), Is.EqualTo(PrimeFactor.Generate(9)));
        }

        [Test]
        public void Testone()
        {
            Assert.That(List(), Is.EqualTo(PrimeFactor.Generate(1)));
        }

        [Test]
        public void TestSix()
        {
            Assert.That(List(2, 3), Is.EqualTo(PrimeFactor.Generate(6)));
        }

        [Test]
        public void Testwo()
        {
            Assert.That(List(2), Is.EqualTo(PrimeFactor.Generate(2)));
        }
    }
}