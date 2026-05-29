namespace Solutions
{
    public class Solution3300
    {
        public int MinElement(int[] nums)
        {
            int min = int.MaxValue;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                string valueStr = Convert.ToString(nums[i]);
                for (int j = 0; j < valueStr.Length; j++)
                {
                    sum += valueStr[j] - '0';
                }
                if (sum < min) min = sum;
                sum = 0;
            }
            return min;
        }
    }
}
