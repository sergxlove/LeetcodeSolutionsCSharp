namespace Solutions
{
    public class Solution0342
    {
        public bool IsPowerOfFour(int n)
        {
            long powerTwo = 1;
            for (int i = 0; i < 16; i++)
            {
                if ((int)powerTwo == n) return true;
                if ((int)powerTwo > n) return false;
                powerTwo *= 4;
            }
            return false;
        }
    }
}
