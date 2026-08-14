namespace Solutions
{
    public class Solution0018
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            List<IList<int>> result = new List<IList<int>>();
            int n = nums.Length;
            for (int i = 0; i < n - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                for (int j = i + 1; j < n - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }
                    int left = j + 1;
                    int right = n - 1;
                    long remaining = (long)target - nums[i] - nums[j]; 
                    while (left < right)
                    {
                        long sum = (long)nums[left] + nums[right];
                        if (sum == remaining)
                        {
                            result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                            while (left < right && nums[left] == nums[left + 1])
                            {
                                left++;
                            }
                            while (left < right && nums[right] == nums[right - 1])
                            {
                                right--;
                            }
                            left++;
                            right--;
                        }
                        else if (sum < remaining)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }
            }
            return result;
        }
    }
}
