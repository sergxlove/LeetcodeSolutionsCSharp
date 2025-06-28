namespace Solutions
{
    public class Solution0003
    {
        public int LengthOfLongestSubstring(string s)
        {
            if(s.Length == 1)
            {
                return 1;
            }
            Dictionary<char, bool> HavesSymbols = new Dictionary<char, bool>();
            int maxRepeatSymbol = 0;
            int countSymbols = 0;
            foreach (var item in s)
            {
                if (HavesSymbols.ContainsKey(item))
                {
                    if (maxRepeatSymbol < countSymbols)
                    {
                        maxRepeatSymbol = countSymbols;
                    }
                    countSymbols = 0;
                    HavesSymbols.Clear();
                }
                HavesSymbols.Add(item, true);
                countSymbols++;
            }
            if(maxRepeatSymbol < countSymbols) maxRepeatSymbol = countSymbols;
            return maxRepeatSymbol;
        }
    }
}
