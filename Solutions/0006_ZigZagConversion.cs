using System.Text;

namespace Solutions
{
    public class Solution0006
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;
            StringBuilder[] rows = new StringBuilder[numRows];
            for(int i = 0; i < numRows; i++)
            {
                rows[i] = new StringBuilder();
            }
            int currentPosition = 0;
            bool digitMove = true;
            for (int i = 0; i < s.Length; i++)
            {
                if(digitMove)
                {
                    rows[currentPosition].Append(s[i]);
                    currentPosition++;
                    if(currentPosition == rows.Length)
                    {
                        digitMove = false;
                        currentPosition-=2;
                    }
                }
                else
                {
                    rows[currentPosition].Append(s[i]);
                    currentPosition--;
                    if(currentPosition == -1)
                    {
                        digitMove = true;
                        currentPosition+=2;
                    }
                }
            }
            StringBuilder result = new StringBuilder();
            foreach (var row in rows)
            {
                result.Append(row.ToString());
                Console.WriteLine(row);
            }
            return result.ToString();
        }
    }
}
