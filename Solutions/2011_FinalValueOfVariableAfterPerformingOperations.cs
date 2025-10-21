namespace Solutions
{
    public class Solution2011
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int x = 0;
            for (int i = 0; i < operations.Length; i++)
            {
                switch (operations[i])
                {
                    case "X++":
                        x++;
                        break;
                    case "++X":
                        ++x;
                        break;
                    case "X--":
                        x--;
                        break;
                    case "--X":
                        --x;
                        break;
                    default:
                        break;
                }
            }
            return x;
        }
    }
}
