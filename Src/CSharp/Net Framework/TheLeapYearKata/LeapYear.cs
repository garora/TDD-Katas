// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace TDD_Katas_project.TheLeapYearKata
{
   public class LeapYear
    {
       public static bool IsLeapYear(int year)
       {
           return (year%4==0 || year%400==0);
       }
    }
}
