namespace Solutions
{
    public class Solution0054
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> result = new List<int>();
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int x = 0;
            int y = 0;
            int count = 1;
            Target move = Target.right;
            while (count <= rows * cols)
            {
                result.Add(matrix[x][y]);
                matrix[x][y] = int.MinValue;
                count++;
                switch(move)
                {
                    case Target.right:
                        y++;
                        if (y == cols || matrix[x][y] == int.MinValue)
                        {
                            x++;
                            y--;
                            move = Target.down;
                        }
                        break;
                    case Target.down:
                        x++;
                        if (x == rows || matrix[x][y] == int.MinValue)
                        {
                            y--;
                            x--;
                            move = Target.left;
                        }
                        break;
                    case Target.left:
                        y--;
                        if (y == -1 || matrix[x][y] == int.MinValue)
                        {
                            x--;
                            y++;
                            move = Target.up;
                        }
                        break;
                    case Target.up:
                        x--;
                        if (x == -1 || matrix[x][y] == int.MinValue)
                        {
                            y++;
                            x++;
                            move = Target.right;
                        }
                        break;
                    default:
                        break;
                }
            }
            return result;
        }

        enum Target
        {
            up,
            down,
            left,
            right
        }
    }
}
