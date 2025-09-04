using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Solutions
{
    public class Solution2566
    {
        public int MinMaxDifference(int num)
        {
            string numStr = num.ToString();
            int max = int.MinValue;
            int min = int.MaxValue;
            for(int i = 0; i < 10; i++)
            {
                numStr = num.ToString().Replace((char)('0' + i), '9');
                if(Convert.ToInt32(numStr) > max) max = Convert.ToInt32(numStr);
            }
            for (int i = 0; i < 10; i++)
            {
                numStr = num.ToString().Replace((char)('0' + i), '0');
                if (Convert.ToInt32(numStr) < min) min = Convert.ToInt32(numStr);
            }
            return max - min;
        }
    }
}
