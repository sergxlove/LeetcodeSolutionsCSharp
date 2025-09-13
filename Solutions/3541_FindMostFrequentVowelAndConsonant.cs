namespace Solutions
{
    public class Solution3541
    {
        public int MaxFreqSum(string s)
        {
            List<char> list = new List<char>()
            {
                'a', 'e', 'i', 'o', 'u'
            };
            Dictionary<char, int> vowels = new Dictionary<char, int>();
            Dictionary<char, int> consonant = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (list.Contains(s[i]))
                {
                    if (vowels.ContainsKey(s[i])) vowels[s[i]]++;
                    else vowels.Add(s[i], 1);
                }
                else
                {
                    if (consonant.ContainsKey(s[i])) consonant[s[i]]++;
                    else consonant.Add(s[i], 1);
                }
            }
            int maxVowels = 0;
            int maxConsonant = 0;
            foreach (var item in vowels)
            {
                if(item.Value > maxVowels) maxVowels = item.Value;
            }
            foreach(var item in consonant)
            {
                if(item.Value > maxConsonant) maxConsonant = item.Value;
            }
            return maxVowels + maxConsonant; 
        }
    }
}
