namespace Solutions
{
    public class Solution0048
    {
        public void Rotate(int[][] matrix)
        {
            int size = matrix.GetLength(0);
            int temp;
            for (int i = 0; i < size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size / 2; j++)
                {
                    temp = matrix[i][j];
                    matrix[i][j] = matrix[i][size - j - 1];
                    matrix[i][size - j - 1] = temp;
                }
            }
        }
    }
}
