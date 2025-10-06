namespace Solutions
{
    public class Solution0004
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> nums = new List<int>();
            nums.AddRange(nums1);
            nums.AddRange(nums2);
            nums.Sort();
            if (nums.Count % 2 == 1)
            {
                int i = 0;
                i = (nums.Count - 1) / 2;
                return nums[i];
            }
            else
            {
                int i = 0;
                i = nums.Count / 2;
                double middle = nums[i] + nums[i - 1];
                return middle / 2;
            }
        }
    }
}
