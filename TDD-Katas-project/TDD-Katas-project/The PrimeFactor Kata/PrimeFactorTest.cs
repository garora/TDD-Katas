using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TDD_Katas_project.The_PrimeFactor_Kata
{
    [TestFixture]
    public class PrimeFactorTest
    {
        private IList List()
        {
            return new ArrayList();
        }

        [Test]
        public void Testone()
        {
            Assert.Equals(List(), PrimeFactor.Generate(1));
        }
    }
}
