// Copyright (c) Gaurav Aroraa
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;

namespace TDD_Katas_NETCore.PasswordVerifier
{
    /// <summary>
    /// PasswordVerifier
    /// </summary>
    public class PasswordVerifier
    {
        /// <summary>
        /// Verifies the specified password.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool Verify(string password) => IsPasswordPassedLengthRule(password, 8);

        private bool IsPasswordPassedLengthRule(string password, int length)
        {
            if (password.Length <= length)
                throw new Exception("Length Rule Violation. Password shuld be of more than characters length.");
            return true;
        }
    }
}