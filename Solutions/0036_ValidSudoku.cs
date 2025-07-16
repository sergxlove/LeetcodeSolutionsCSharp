namespace Solutions
{
    public class Solution0036
    {
        public bool IsValidSudoku(char[][] board)
        {
            bool[] values = new bool[9];
            int[] positionX = { 0, 0, 0, 3, 3, 3, 6, 6, 6 };
            int[] positionY = { 0, 3, 6, 0, 3, 6, 0, 3, 6 };
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (values[(int)char.GetNumericValue(board[i][j]) - 1])
                        {
                            return false;
                        }
                        else
                        {
                            values[(int)char.GetNumericValue(board[i][j]) - 1] = true;
                        }
                    }
                }
                for (int j = 0; j < 9; j++)
                {
                    values[j] = false;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[j][i] != '.')
                    {
                        if (values[(int)char.GetNumericValue(board[j][i]) - 1])
                        {
                            return false;
                        }
                        else
                        {
                            values[(int)char.GetNumericValue(board[j][i]) - 1] = true;
                        }
                    }
                }
                for (int j = 0; j < 9; j++)
                {
                    values[j] = false;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (board[positionX[i] + j][positionY[i] +k]!='.')
                        {
                            if (values[(int)char.GetNumericValue(board[positionX[i] + j][positionY[i] + k]) - 1])
                            {
                                return false;
                            }
                            else
                            {
                                values[(int)char.GetNumericValue(board[positionX[i] + j][positionY[i] + k]) - 1] = true;
                            }
                        }
                    }
                }
                for (int j = 0; j < 9; j++)
                {
                    values[j] = false;
                }
            }
            return true;
        }
    }
}
