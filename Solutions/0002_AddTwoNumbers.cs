using System.Text;

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
            var dummy = new ListNode(-1);
            var current = dummy;

            var carry = 0;
            while (l1 != null || l2 != null)
            {
                var value1 = l1 == null ? 0 : l1.val;
                var value2 = l2 == null ? 0 : l2.val;

                var sum = value1 + value2 + carry;
                carry = sum / 10;
                sum %= 10;
                current.next = new ListNode(sum);

                current = current.next;
                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (carry != 0)
                current.next = new ListNode(carry);

            return dummy.next;
        }
    }
}
