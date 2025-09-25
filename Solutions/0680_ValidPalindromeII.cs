using System.Text;

namespace Solutions
{
    public class Solution0680
    {
        public bool ValidPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return IsPalindrome(s, left + 1, right) ||
                           IsPalindrome(s, left, right - 1);
                }
                left++;
                right--;
            }
            return true;
        }

        private bool IsPalindrome(string s, int left, int right)
        {
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
