using System.Text;

namespace Solutions
{
    public class Solution2075
    {
        public string DecodeCiphertext(string encodedText, int rows)
        {
            if (rows == 1) return encodedText;
            int cols = encodedText.Length / rows;
            StringBuilder result = new StringBuilder();
            for (int startCol = 0; startCol < cols; startCol++)
            {
                int row = 0;
                int col = startCol;
                while (row < rows && col < cols)
                {
                    int index = row * cols + col;
                    result.Append(encodedText[index]);
                    row++;
                    col++;
                }
            }
            return result.ToString().TrimEnd();
        }
    }
}
