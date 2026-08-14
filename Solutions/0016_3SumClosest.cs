namespace Solutions
{
    public class Solution0016
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int n = nums.Length;
            int closestSum = nums[0] + nums[1] + nums[2]; 
            for (int i = 0; i < n - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                int left = i + 1;
                int right = n - 1;
                while (left < right)
                {
                    int currentSum = nums[i] + nums[left] + nums[right];
                    if (currentSum == target)
                    {
                        return currentSum;
                    }
                    if (Math.Abs(currentSum - target) < Math.Abs(closestSum - target))
                    {
                        closestSum = currentSum;
                    }
                    if (currentSum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return closestSum;
        }
    }
}
