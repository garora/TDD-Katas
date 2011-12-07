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
        private IList<int?> List(params int[] ints)
        {
            IList<int?> list = new List<int?>();
            foreach (int i in ints)
            {
                list.Add(i);
            }
            return list;
        }

        [Test]
        public void Testone()
        {
            Assert.That(List(), Is.EqualTo(PrimeFactor.Generate(1)));
        }
        [Test]
        public void Testwo()
        {
            Assert.That(List(2), Is.EqualTo(PrimeFactor.Generate(2)));
        }
    }
}
