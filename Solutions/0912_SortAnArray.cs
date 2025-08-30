namespace Solutions
{
    public class Solution0912
    {
        public int[] SortArray(int[] nums)
        {
            List<int> list = nums.ToList();
            list.Sort();
            return list.ToArray();
        }
    }
}
