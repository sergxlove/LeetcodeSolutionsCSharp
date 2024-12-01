namespace Solutions
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution0002
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            List<int> digitsOne = new();
            List<int> digitsTwo = new();
            List<int> resultNumber = new();
            while (l1 != null)
            {
                digitsOne.Add(l1.val);
                l1 = l1.next;
            }
            while(l2 != null)
            {
                digitsTwo.Add(l2.val);
                l2 = l2.next;
            }
            int maxAviableDigitForOperation;
            if(digitsOne.Count > digitsTwo.Count)
            {
                maxAviableDigitForOperation = digitsTwo.Count;
            }
            else
            {
                maxAviableDigitForOperation = digitsOne.Count;
            }
            int result;
            int cashe = 0;
            for (int i = 0; i < maxAviableDigitForOperation; i++)
            {
                result = digitsOne[digitsOne.Count - i + 1] + digitsTwo[digitsTwo.Count - i + 1] + cashe;
                if(result >= 10)
                {
                    resultNumber.Add(result % 10);
                    cashe = 1;
                }
                else
                {
                    resultNumber.Add(result);
                    cashe = 0;
                }
            }
            ListNode head = new(resultNumber[0]);
            ListNode current = head;
            for(int i = 1; i< maxAviableDigitForOperation; i++)
            {
                current.next = new ListNode(resultNumber[i]);
                current = current.next;
            }
            return head;
        }
    }
}
