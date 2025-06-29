namespace Solutions
{
    public class Solution0014
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string result = strs[0];
            for (int i = 1; i < strs.Length; )
            {
                if (!strs[i].StartsWith(result))
                {
                    result = result.Remove(result.Length - 1);
                }
                else
                {
                    i++;
                }
                if(result.Length == 0)
                {
                    return result;
                }
            }
            return result;
        }
    }
}
