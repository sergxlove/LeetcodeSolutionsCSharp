namespace Solutions
{
    public class Solution1748
    {
        public int SumOfUnique(int[] nums)
        {
            List<int> uniqueValue = new List<int>();
            bool isUnique = true;
            for (int i = 0; i < nums.Length; i++)
            {
                isUnique = true;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j) continue;
                    if (nums[i]  == nums[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    uniqueValue.Add(nums[i]);
                }
            }
            int sum = 0;
            for (int i = 0; i < uniqueValue.Count; i++)
            {
                sum+= uniqueValue[i];
            }
            return sum;
        }
    }
}
