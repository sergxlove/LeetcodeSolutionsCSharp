using System.Text.RegularExpressions;

namespace Solutions
{
    public class Solution2299
    {
        public bool StrongPasswordCheckerII(string password)
        {
            if (password.Length < 8) return false;
            int quantityUpper = 0;
            int quantityLower = 0;
            int quantityDigit = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password[i])) quantityUpper++;
                if (Char.IsLower(password[i])) quantityLower++;
                if (Char.IsDigit(password[i])) quantityDigit++;
            }
            if (quantityUpper < 1) return false;
            if (quantityLower < 1) return false;
            if (quantityDigit < 1) return false;
            if (!Regex.IsMatch(password, @"[!@#$%^&*()\-+]")) return false;
            if (!Regex.IsMatch(password, @"(.)\1")) return false;
            return true;
        }
    }
}
