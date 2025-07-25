using System.Text;

namespace Solutions
{
    public class Solution1717
    {
        public int MaximumGain(string s, int x, int y) //no work
        {
            int result = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append(s);
            bool isExit = false;
            string firstPair;
            int currentValue = 0;
            bool isSwap = true;
            if (x > y)
            {
                firstPair = "ab";
                currentValue = x;
            }
            else
            {
                firstPair = "ba";
                currentValue = y;
            }
            while (!isExit)
            {
                if (isSwap)
                {
                    isSwap = false;
                    for (int i = 0; i < sb.Length - 1; i++)
                    {
                        if ((s[i] == firstPair[0] && s[i + 1] == firstPair[1]))
                        {
                            result += currentValue;
                            isSwap = true;
                            sb.Remove(i, 2);
                            break;
                        }
                    }
                }
                else
                {
                    if (firstPair == "ab") firstPair = "ba";
                    else firstPair = "ab";
                    if (currentValue == x) currentValue = y;
                    else currentValue = x;
                    for (int i = 0; i < sb.Length - 1; i++)
                    {
                        if ((s[i] == firstPair[0] && s[i + 1] == firstPair[1]))
                        {
                            result += currentValue;
                            isSwap = true;
                            sb.Remove(i, 2);
                            break;
                        }
                    }
                    if (!isSwap) isExit = true;
                    if (firstPair == "ab") firstPair = "ba";
                    else firstPair = "ab";
                    if (currentValue == x) currentValue = y;
                    else currentValue = x;
                }
            }
            return result;
        }
    }
}
