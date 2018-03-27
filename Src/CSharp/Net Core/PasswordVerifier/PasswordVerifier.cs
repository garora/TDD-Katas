using System;

namespace TDD_Katas_NETCore.PasswordVerifier
{
    public class PasswordVerifier
    {
        public bool Verify(string password)
        {
            return IsPasswordPassedLengthRule(password, 8);
        }

        private bool IsPasswordPassedLengthRule(string password, int length)
        {
            if(password.Length <= length)
                throw new Exception("Length Rule Violation. Password shuld be of more than characters length.");
            return true;
        }
    }
}