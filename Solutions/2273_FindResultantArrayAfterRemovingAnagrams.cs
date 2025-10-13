namespace Solutions
{
    public class Solution2273
    {
        public IList<string> RemoveAnagrams(string[] words)
        {
            var result = new List<string>();

            foreach (var word in words)
            {
                if (result.Count == 0)
                {
                    result.Add(word);
                    continue;
                }
                var lastWord = result[result.Count - 1];
                if (!AreAnagrams(lastWord, word))
                {
                    result.Add(word);
                }
            }
            return result;
        }

        private bool AreAnagrams(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            var charCount = new int[26];
            foreach (char c in s1)
            {
                charCount[c - 'a']++;
            }
            foreach (char c in s2)
            {
                charCount[c - 'a']--;
                if (charCount[c - 'a'] < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
