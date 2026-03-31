namespace Solutions
{
    public class Solution2404
    {
        public int MostFrequentEven(int[] nums)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (num % 2 != 0) continue;
                if (frequencyMap.ContainsKey(num)) frequencyMap[num]++;
                else frequencyMap[num] = 1;
            }
            if (frequencyMap.Count == 0) return -1;
            int mostFrequent = -1;
            int maxCount = 0;
            foreach (var pair in frequencyMap)
            {
                if (pair.Value > maxCount || (pair.Value == maxCount && pair.Key < mostFrequent))
                {
                    mostFrequent = pair.Key;
                    maxCount = pair.Value;
                }
            }
            return mostFrequent;
        }
    }
}
