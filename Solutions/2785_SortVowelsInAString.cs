using System.Text;

namespace Solutions
{
    public class Solution2785
    {
        public string SortVowels(string s)
        {
            List<char> needChar = new List<char>()
            {
                'a', 'e', 'i', 'o', 'u',
                'A', 'E', 'I', 'O', 'U'
            };
            List<char> currentChar = new List<char>();
            List<char> currentS = new List<char>();
            List<int> positionChar = new List<int>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (needChar.Contains(s[i]))
                {
                    currentChar.Add(s[i]);
                    positionChar.Add(i);
                    currentS.Add('*');
                    continue;
                }
                currentS.Add(s[i]);
            }
            currentChar.Sort();
            for (int i = 0; i < positionChar.Count; i++)
            {
                currentS[positionChar[i]] = currentChar[i];
            }
            for (int i = 0; i < currentS.Count; i++)
            {
                sb.Append(currentS[i]);
            }
            return sb.ToString();
        }
    }
}
