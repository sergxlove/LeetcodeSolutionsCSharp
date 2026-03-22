namespace Solutions
{
    public class Solution1886
    {
        public bool FindRotation(int[][] mat, int[][] target)
        {
            int n = mat.Length;
            for (int rotation = 0; rotation < 4; rotation++)
            {
                if (AreMatricesEqual(mat, target, n))
                {
                    return true;
                }
                mat = Rotate90(mat, n);
            }
            return false;
        }

        private bool AreMatricesEqual(int[][] mat, int[][] target, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i][j] != target[i][j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private int[][] Rotate90(int[][] matrix, int n)
        {
            int[][] rotated = new int[n][];
            for (int i = 0; i < n; i++)
            {
                rotated[i] = new int[n];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rotated[j][n - 1 - i] = matrix[i][j];
                }
            }
            return rotated;
        }
    }
}
