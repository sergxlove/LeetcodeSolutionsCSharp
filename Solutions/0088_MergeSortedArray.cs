namespace Solutions
{
    public class Solution0088
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            List<int> nums = new List<int>(n + m);
            for(int i = 0; i < m; i++)
            {
                nums.Add(nums1[i]);
            }
            nums.AddRange(nums2);
            nums.Sort();
            for (int i = 0; i < nums1.Length; i++)
            {
                nums1[i] = nums[i];
            }
        }
    }
}
