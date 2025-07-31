namespace Solutions
{
    public class Solution0898
    {
        public int SubarrayBitwiseORs(int[] arr)
        {
            HashSet<int> result = new HashSet<int>();
            HashSet<int> current = new HashSet<int>();

            foreach (int num in arr)
            {
                HashSet<int> next = new HashSet<int>();
                next.Add(num);
                foreach (int val in current)
                {
                    next.Add(val | num);
                }
                foreach (int val in next)
                {
                    result.Add(val);
                }
                current = next;
            }

            return result.Count;
        }
    }
}
