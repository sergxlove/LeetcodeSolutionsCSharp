using System.Text;

namespace Solutions
{
    public class Solution1957
    {
        public string MakeFancyString(string s)
        {
            StringBuilder result = new StringBuilder();
            int count = 1;
            char currentChar = s[0];
            result.Append(currentChar);
            for (int i = 1; i < s.Length; i++)
            {
                if (currentChar != s[i])
                {
                    count = 1;
                    currentChar = s[i];
                    result.Append(s[i]);
                    continue;
                }
                if(count == 2) continue;
                count++;
                result.Append(s[i]);
            }
            return result.ToString();
        }
    }
}
