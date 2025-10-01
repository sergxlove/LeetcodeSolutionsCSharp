namespace Solutions
{
    public class Solution1518
    {
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            int result = 0;
            int empty = 0;
            int full = numBottles;
            while(full > 0)
            {
                result += full;
                empty += full;
                full = 0;
                if(empty >= numExchange)
                {
                    full = empty / numExchange;
                    empty = empty % numExchange;
                }
            }
            return result;
        }
    }
}
