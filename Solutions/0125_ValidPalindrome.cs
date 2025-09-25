using System.Text;

namespace Solutions
{
    public class Solution0125
    {
        public bool IsPalindrome(string s)
        {
            StringBuilder sb = new StringBuilder();
            string validStr = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] >= 65 && (int)s[i] <= 90 || (int)s[i] >= 97 && (int)s[i] <= 122 
                    || (int)s[i] >= 48 && (int)s[i] <= 57)
                {
                    sb.Append(s[i]);
                }
            }
            validStr = sb.ToString().ToLower();
            for (int i = 0; i < validStr.Length / 2; i++)
            {
                if (validStr[i] != validStr[validStr.Length - 1 - i]) return false;
            }
            return true;
        }
    }
}
