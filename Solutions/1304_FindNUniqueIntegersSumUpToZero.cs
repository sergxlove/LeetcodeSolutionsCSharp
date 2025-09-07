namespace Solutions
{
    public class Solution1304
    {
        public int[] SumZero(int n)
        {
            int[] result = new int[n];
            int startPosition = 0;
            bool isSignNegative = false;
            int currentValue = 1;
            if (n % 2 != 0)
            {
                result[0] = 0;
                startPosition = 1;
            }
            for (int i = startPosition; i < n; i++)
            {
                if(isSignNegative)
                {
                    isSignNegative = false;
                    result[i] = currentValue * (-1);
                    currentValue++;
                }
                else
                {
                    isSignNegative = true;
                    result[i] = currentValue;
                }
            }
            List<int> sorted = result.ToList();
            sorted.Sort();
            return sorted.ToArray();
        }
    }
}
