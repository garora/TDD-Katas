using System;
using System.Linq;

namespace TDD_Katas_project.PasswordVerifierTDD
{
    public  class PasswordVerifier
    {
        int a = 0;
        public string Verify(string password)
        {
            password = password.Trim();
            String message = "Password is beingChecked";
            if (password.Length > 8)
                a += 1;
            else
                throw new System.ArgumentException("password is too short");
            if (!string.IsNullOrEmpty(password))
                a += 1;
            else
                throw new System.ArgumentException("password is null");
            if (password.Any(char.IsUpper))
                a += 1;
            else
                throw new System.ArgumentException("password doesn't contain a uppercase element");
            if (password.Any(char.IsLower))
                a += 1;
            else
                throw new System.ArgumentException("password doesn't contain a lowercase element");
            if (password.Any(char.IsDigit))
                a += 1;
            else
                throw new System.ArgumentException("password doesn't contain a number");
            if ((a >= 3) && (password.Length > 8 && password.Any(char.IsLower)))
                message = message.Replace("beingChecked", "OK");
            else
                message = message.Replace("beingChecked", "never Ok");
            return message;
        }

    }
}
