namespace Solutions
{
    public class Solution0037
    {
        public void SolveSudoku(char[][] board)
        {
            Solve(board);
        }
        public bool Solve(char[][] board)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row][col] == '.')
                    {
                        for (char num = '1'; num <= '9'; num++)
                        {
                            if (IsValid(board, row, col, num))
                            {
                                board[row][col] = num;

                                if (Solve(board))
                                    return true;
                                else
                                    board[row][col] = '.';
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        private bool IsValid(char[][] board, int row, int col, char num)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[row][i] == num) return false;
            }
            for (int i = 0; i < 9; i++)
            {
                if (board[i][col] == num) return false;
            }
            int boxRow = row - row % 3;
            int boxCol = col - col % 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[boxRow + i][boxCol + j] == num)
                        return false;
                }
            }
            return true;
        }
    }
}
