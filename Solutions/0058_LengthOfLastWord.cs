namespace Solutions
{
    public class Solution0058
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            var words = s.Split(' ');
            return words[words.Length - 1].Length;
        }
    }
}
