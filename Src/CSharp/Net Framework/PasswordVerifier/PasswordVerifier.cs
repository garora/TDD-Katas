using System;
using System.Linq;

namespace TDD_Katas_project.PasswordVerifier
{
    public class PasswordVerifier
    {
        private int _counter;

        public string Verify(string password)
        {
            password = password.Trim();
            var message = "Password is beingChecked";
            if (password.Length > 8)
                _counter += 1;
            else
                throw new ArgumentException("password is too short");
            if (!string.IsNullOrEmpty(password))
                _counter += 1;
            else
                throw new ArgumentException("password is null");
            if (password.Any(char.IsUpper))
                _counter += 1;
            else
                throw new ArgumentException("password doesn't contain a uppercase element");
            if (password.Any(char.IsLower))
                _counter += 1;
            else
                throw new ArgumentException("password doesn't contain a lowercase element");
            if (password.Any(char.IsDigit))
                _counter += 1;
            else
                throw new ArgumentException("password doesn't contain a number");
            if (_counter >= 3 && password.Length > 8 && password.Any(char.IsLower))
                message = message.Replace("beingChecked", "OK");
            else
                message = message.Replace("beingChecked", "never Ok");
            return message;
        }
    }
}