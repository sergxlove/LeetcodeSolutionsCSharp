namespace Solutions
{
    public class Solution0231
    {
        public bool IsPowerOfTwo(int n)
        {
            long powerTwo = 1;
            for(int i = 0; i < 31; i++)
            {
                if ((int)powerTwo == n) return true;
                if ((int)powerTwo > n) return false;
                powerTwo *= 2;
            }
            return false;
        }
    }
}
