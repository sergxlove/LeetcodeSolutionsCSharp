namespace Solutions
{
    public class Solution0217
    {
        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, bool> duplicates = new();
            foreach (int num in nums)
            {
                if(duplicates.ContainsKey(num)) return true;
                else duplicates.Add(num, true);
            }
            return false;
        }
    }
}
