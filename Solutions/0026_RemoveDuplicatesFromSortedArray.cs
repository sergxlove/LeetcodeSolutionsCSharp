namespace Solutions
{
    public class Solution0026
    {
        public int RemoveDuplicates(int[] nums)
        {
            int k = 0;
            int lastvalue = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if(lastvalue != nums[i])
                {
                    lastvalue = nums[i];
                    nums[k] = lastvalue;
                    k++;
                }
            }
            return k;
        }
    }
}
