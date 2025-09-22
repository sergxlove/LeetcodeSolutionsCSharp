namespace Solutions
{
    public class Solution3005
    {
        public int MaxFrequencyElements(int[] nums)
        {
            Dictionary<int, int> elements = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if(elements.ContainsKey(num)) elements[num]++;
                else elements.Add(num, 1);
            }
            int max = 0;
            foreach (var num in elements)
            {
                if(max < num.Value) max = num.Value;
            }
            int result = 0;
            foreach (var num in elements)
            {
                if (num.Value == max) result += max;
            }
            return result;
        }
    }
}
