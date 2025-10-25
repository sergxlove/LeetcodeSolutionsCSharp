namespace Solutions
{
    public class Solution0069
    {
        public int MySqrt(int x)
        {
            if (x == 0 || x == 1) return x;
            double precision = 1e-15;
            double newX = x;
            double root;
            while(true)
            {
                root = 0.5 * (newX + (x / newX));
                if (Math.Abs(root - newX) < precision) break;
                newX = root;
            }
            return Convert.ToInt32(Math.Truncate(root));
        }
    }
}
