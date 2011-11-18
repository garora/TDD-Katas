using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TDD_Katas_project.FizzBuzzKata
{
   [TestFixture]
   [Category("TheFizzBuzzKata")]
   public class TestFizzBuzz
    {
       [Test]
       public void Can_Test_Fizz_Buzz()
       {
           FizzBuzz.PrintFizzBuzz();
       }
    }
}
