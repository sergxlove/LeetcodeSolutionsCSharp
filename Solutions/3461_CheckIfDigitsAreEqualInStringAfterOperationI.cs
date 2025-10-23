using System.Text;

namespace Solutions
{
    public class Solution3461
    {
        public bool HasSameDigits(string s)
        {
            bool isExit = false;
            StringBuilder newS = new StringBuilder();
            while(!isExit)
            {
                for (int i = 0; i < s.Length- 1; i++)
                {
                    newS.Append((Convert.ToInt32(char.GetNumericValue(s[i])) + Convert.ToInt32(char.GetNumericValue(s[i+1]))) % 10);
                }
                s = newS.ToString();
                newS.Clear();
                if(s.Length == 2)
                {
                    isExit = true;
                }
            }
            if (s[0] == s[1])
            {
                return true;
            }
            return false;
        }
    }
}
