using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TDD_Katas_project.The_PrimeFactor_Kata
{
    [TestFixture]
    [Category("The PrimeFactor Kata")]
    public class PrimeFactorTest
    {
        private static IList List()
        {
            return new List<int>();
        }

        [Test]
        public void Testone()
        {
            Assert.That(List(),Is.EqualTo(PrimeFactor.Generate(1)));
        }
    }
}
