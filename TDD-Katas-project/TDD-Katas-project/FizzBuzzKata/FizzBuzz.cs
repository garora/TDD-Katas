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
           ResultFizzBuzz = GetNumbers(ResultFizzBuzz);
           return ResultFizzBuzz;
       }

       private static string GetNumbers(string ResultFizzBuzz)
       {
           for (int i = 1; i <= 100; i++)
           {
               if (i % 3 == 0) ResultFizzBuzz += " " + "Fizz";
               ResultFizzBuzz += " " + (i).ToString();
           }
           return ResultFizzBuzz.Trim();
       }
    }
}
