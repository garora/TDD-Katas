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
        private static IList<int> List(int ints)
        {
            IList<int> list = new List<int>();
            for (var i = 0; i < ints; i++)
                list.Add(i);
            return list;
        }

        [Test]
        public void Testone()
        {
            Assert.That(List(0), Is.EqualTo(PrimeFactor.Generate(1)));
        }
        [Test]
        public void Testwo()
        {
            Assert.That(List(2), Is.EqualTo(PrimeFactor.Generate(2)));
        }
    }
}
