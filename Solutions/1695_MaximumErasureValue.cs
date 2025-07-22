namespace Solutions
{
    public class Solution1695
    {
        public int MaximumUniqueSubarray(int[] nums)
        {
            int result = 0;
            int currentSum = 0;
            int left = 0;
            HashSet<int> uniqueValues = new HashSet<int>();
            for (int right = 0; right < nums.Length; right++)
            {
                while (uniqueValues.Contains(nums[right]))
                {
                    uniqueValues.Remove(nums[left]);
                    currentSum -= nums[left];
                    left++;
                }
                uniqueValues.Add(nums[right]);
                currentSum += nums[right];
                result = Math.Max(result, currentSum);
            }
            return result;
        }
    }
}
