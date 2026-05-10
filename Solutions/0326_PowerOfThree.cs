namespace Solutions
{
    public class Solution0326
    {
        public bool IsPowerOfThree(int n)
        {
            long powerTwo = 1;
            for (int i = 0; i < 20; i++)
            {
                if ((int)powerTwo == n) return true;
                if ((int)powerTwo > n) return false;
                powerTwo *= 3;
            }
            return false;
        }
    }
}
