namespace Solutions
{
    public class Solution0219
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> lastIndex = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (lastIndex.ContainsKey(nums[i]))
                {
                    if (i - lastIndex[nums[i]] <= k) return true;
                }
                lastIndex[nums[i]] = i;
            }
            return false;
        }
    }
}
