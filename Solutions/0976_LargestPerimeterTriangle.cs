namespace Solutions
{
    public class Solution0976
    {
        public int LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);
            Array.Reverse(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int a = nums[i];
                int b = nums[i + 1];
                int c = nums[i + 2];
                if (b + c > a)
                {
                    return a + b + c;
                }
            }
            return 0;
        }
    }
}
