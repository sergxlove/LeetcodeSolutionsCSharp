namespace Solutions
{
    public class Solution3330
    {
        public int PossibleStringCount(string word)
        {
            if (word.Length == 0) return 0;
            List<int> quantityChars = new List<int>();
            char currentChar = word[0];
            int k = 0;
            int result = 0;
            quantityChars.Add(1);
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] != currentChar)
                {
                    currentChar = word[i];
                    quantityChars.Add(1);
                    k++;
                }
                else
                {
                    quantityChars[k]++;
                }
            }
            foreach (int item in quantityChars)
            {
                if (item > 1) result += item - 1;
            }
            return result + 1;
        }
    }
}
