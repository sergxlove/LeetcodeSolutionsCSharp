namespace Solutions
{
    public class Solution0136
    {
        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> valuePairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(valuePairs.ContainsKey(nums[i]))
                {
                    valuePairs[nums[i]]++;
                }
                else
                {
                    valuePairs.Add(nums[i], 1);
                }
            }
            foreach (var item in valuePairs)
            {
                if(item.Value == 1)
                {
                    return item.Key;
                }
            }
            return 0;
        }
    }
}
