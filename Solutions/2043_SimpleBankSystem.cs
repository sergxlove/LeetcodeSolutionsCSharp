namespace Solutions
{
    public class Solution2043
    {
        public class Bank
        {
            private long[] balance;
            private int n;
            public Bank(long[] balance)
            {
                this.balance = balance;
                n = balance.Length;
            }

            public bool Transfer(int account1, int account2, long money)
            {
                if(account1 < 0 || account1 > n)
                    return false;
                if(account2 < 0 || account2 > n)
                    return false;
                if (balance[account1-1] < money)
                    return false;
                balance[account1-1] -= money;
                balance[account2-1] += money;
                return true;
            }

            public bool Deposit(int account, long money)
            {
                if (account < 0 || account > n)
                    return false;
                balance[account-1] += money;
                return true;
            }

            public bool Withdraw(int account, long money)
            {
                if(account  < 0 || account > n)
                    return false;
                if (balance[account-1] < money)
                    return false;
                balance[account-1] -= money;
                return true;
            }
        }
    }
}
