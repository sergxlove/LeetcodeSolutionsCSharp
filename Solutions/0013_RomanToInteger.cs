namespace Solutions
{
    public class Solution0013
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> values = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            int result = 0;
            char currentSymbols = ' ';
            char nextSymbols = ' ';
            for(int i = s.Length - 1; i >= 0; i--)
            {
                if(i != 0)
                {
                    currentSymbols = s[i];
                    nextSymbols = s[i - 1];
                    if (values[currentSymbols] > values[nextSymbols])
                    {
                        result += values[currentSymbols] - values[nextSymbols];
                        i--;
                    }
                    else
                    {
                        result += values[currentSymbols];
                    }
                }
                else
                {
                    currentSymbols = s[i];
                    result += values[currentSymbols];
                }
            }
            return result;
        }
    }
}
