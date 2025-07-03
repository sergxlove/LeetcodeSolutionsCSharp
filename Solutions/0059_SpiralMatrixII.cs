namespace Solutions
{
    public class Solution0059
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] result = new int[n][];
            for(int i = 0; i<n;i++)
            {
                result[i] = new int[n];
            }
            int count = 1;
            int x = 0;
            int y = 0;
            Target move = Target.right;
            while(count <= n * n)
            {
                result[y][x] = count;
                count++;
                switch(move)
                {
                    case Target.right:
                        x++;
                        if (x == n || result[y][x] != 0)
                        {
                            x--;
                            y++;
                            move = Target.down;
                        }
                        break;
                    case Target.down:
                        y++;
                        if(y == n || result[y][x] != 0)
                        {
                            y--;
                            x--;
                            move = Target.left;
                        }
                        break;
                    case Target.left:
                        x--;
                        if(x == -1 || result[y][x] != 0)
                        {
                            x++;
                            y--;
                            move = Target.up;
                        }
                        break;
                    case Target.up:
                        y--;
                        if(y == -1 || result[y][x] != 0)
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
