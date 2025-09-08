namespace Solutions
{
    public class Solution1317
    {
        public int[] GetNoZeroIntegers(int n)
        {
            int[] result = new int[2];
            int a = 1;
            int b = n - 1;
            while (a != n)
            {
                if (!a.ToString().Contains('0') && !b.ToString().Contains('0'))
                {
                    result[0] = a;
                    result[1] = b;
                    return result;
                }
                a++;
                b--;
            }
            return result;
        }
    }
}
