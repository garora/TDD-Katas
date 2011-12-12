namespace TDD_Katas_project.The_LeapYear_Kata
{
   public class LeapYear
    {
       public static bool IsLeapYear(int year)
       {
           bool blnResult = false;
           if (year %4 ==0 || year % 400 ==0)
           {
               blnResult = true;
           }
           return blnResult;
       }
    }
}
