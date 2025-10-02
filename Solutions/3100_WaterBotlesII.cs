namespace Solutions
{
    public class Solution3100
    {
        public int MaxBottlesDrunk(int numBottles, int numExchange)
        {
            int result = numBottles;
            int empty = numBottles;
            while(empty >= numExchange)
            {
                empty -= numExchange;
                result++;
                empty++;
                numExchange++;
            }
            return result;
        }
    }
}
