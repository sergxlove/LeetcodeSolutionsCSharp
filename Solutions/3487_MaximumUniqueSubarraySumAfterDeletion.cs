namespace Solutions
{
    public class Solution3487
    {
        public int MaxSum(int[] nums)
        {
            HashSet<int> uniqueValue = new HashSet<int>();
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= 0) continue;
                if(!uniqueValue.Contains(nums[i])) 
                {
                    uniqueValue.Add(nums[i]);
                    result += nums[i];
                }
            }
            if (uniqueValue.Count == 0) result = nums.Max();
            return result;
        }
    }
}
