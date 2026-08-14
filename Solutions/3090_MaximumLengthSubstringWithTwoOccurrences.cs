namespace Solutions
{
    public class Solution3090
    {
        public int MaximumLengthSubstring(string s)
        {
            int left = 0;
            int maxLength = 0;
            int[] freq = new int[26]; 

            for (int right = 0; right < s.Length; right++)
            {
                char currentChar = s[right];
                freq[currentChar - 'a']++;
                while (freq[currentChar - 'a'] > 2)
                {
                    char leftChar = s[left];
                    freq[leftChar - 'a']--;
                    left++;
                }
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}
