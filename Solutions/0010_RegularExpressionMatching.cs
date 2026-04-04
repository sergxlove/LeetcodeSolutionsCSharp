namespace Solutions
{
    public class Solution0010
    {
        public bool IsMatch(string s, string p)
        {
            int m = s.Length;
            int n = p.Length;
            bool[] prev = new bool[n + 1];
            bool[] curr = new bool[n + 1];
            prev[0] = true;
            for (int j = 1; j <= n; j++)
            {
                if (p[j - 1] == '*' && j >= 2) prev[j] = prev[j - 2];
            }
            for (int i = 1; i <= m; i++)
            {
                curr[0] = false;
                for (int j = 1; j <= n; j++)
                {
                    char sc = s[i - 1];
                    char pc = p[j - 1];
                    if (pc == '*')
                    {
                        char prevChar = p[j - 2];
                        curr[j] = curr[j - 2]; 
                        if (prevChar == '.' || prevChar == sc) curr[j] = curr[j] || prev[j];
                    }
                    else
                    {
                        if (pc == '.' || pc == sc) curr[j] = prev[j - 1];
                        else curr[j] = false;
                    }
                }
                var temp = prev;
                prev = curr;
                curr = temp;
            }
            return prev[n];
        }
    }
}
