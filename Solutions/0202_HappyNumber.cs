namespace Solutions
{
    public class Solution0202
    {
        public bool IsHappy(int n)
        {
            HashSet<int> seenNumbers = new HashSet<int>();
            int sum;
            int number;
            while (n != 1 && !seenNumbers.Contains(n))
            {
                seenNumbers.Add(n);
                sum = 0;
                number = n;
                while (number > 0)
                {
                    int digit = number % 10;         
                    sum += digit * digit;              
                    number /= 10;                      
                }
                n = sum;
            }
            if (n == 1) return true;
            else return false;
        }
    }
}
