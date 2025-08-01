namespace Solutions
{
    public class Solution0118
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            result.Add(new List<int> { 1 });
            int count = 2;
            while (count <= numRows)
            {
                List<int> currentRow = new List<int>();
                currentRow.Add(1);
                for (int i = 1; i < count - 1; i++)
                {
                    currentRow.Add(result[count - 2][i - 1] + result[count - 2][i]);
                }
                if (count > 1)
                {
                    currentRow.Add(1);
                }
                result.Add(currentRow);
                count++;
            }
            return result;
        }
    }
}
