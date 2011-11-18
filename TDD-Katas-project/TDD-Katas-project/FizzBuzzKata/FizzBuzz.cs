using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TDD_Katas_project.FizzBuzzKata
{
   public class FizzBuzz
    {
       public static string PrintFizzBuzz()
       {
           var ResultFizzBuzz = string.Empty;
           for (int i = 0; i < 100; i++)
           {
               ResultFizzBuzz += " " + (i+1).ToString();
           }
           return ResultFizzBuzz;
       }
    }
}
