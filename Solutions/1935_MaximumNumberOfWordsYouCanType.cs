namespace Solutions
{
    public class Solution1935
    {
        public int CanBeTypedWords(string text, string brokenLetters)
        {
            var words = text.Split(' ');
            int result = 0;
            bool isValid = false;
            for (int i = 0; i < words.Length; i++)
            {
                isValid = true;
                for (int j = 0; j < brokenLetters.Length; j++)
                {
                    if (words[i].Contains(brokenLetters[j]))
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid) result++;
            }
            return result;
        }
    }
}
