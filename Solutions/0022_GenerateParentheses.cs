using System.Text;

namespace Solutions
{
    public class Solution0022
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            StringBuilder sb = new StringBuilder();
            Backtrack(result, sb, 0, 0, n);
            return result;
        }

        private void Backtrack(List<string> result, StringBuilder sb, int open, int close, int max)
        {
            if (sb.Length == max * 2)
            {
                result.Add(sb.ToString());
                return;
            }
            if (open < max)
            {
                sb.Append('(');
                Backtrack(result, sb, open + 1, close, max);
                sb.Remove(sb.Length - 1, 1); 
            }
            if (close < open)
            {
                sb.Append(')');
                Backtrack(result, sb, open, close + 1, max);
                sb.Remove(sb.Length - 1, 1); 
            }
        }
    }
}
