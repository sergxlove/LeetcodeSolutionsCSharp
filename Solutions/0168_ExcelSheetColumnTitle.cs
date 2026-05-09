namespace Solutions
{
    public class Solution0168
    {
        public string ConvertToTitle(int columnNumber)
        {
            string result = string.Empty;
            while (columnNumber > 0)
            {
                columnNumber--;
                char letter = (char)('A' + columnNumber % 26);
                result = letter + result;
                columnNumber /= 26;
            }
            return result;
        }
    }
}
