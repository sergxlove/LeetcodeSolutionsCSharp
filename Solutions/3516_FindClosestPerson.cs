namespace Solutions
{
    public class Solution3516
    {
        public int FindClosest(int x, int y, int z)
        {
            int diffX = 0;
            int diffY = 0;
            if (x < z) diffX = z - x;
            else diffX = x - z;
            if (y < z) diffY = z - y;
            else diffY = y - z;
            if (diffX > diffY) return 2;
            if (diffY > diffX) return 1;
            return 0;
        }
    }
}
