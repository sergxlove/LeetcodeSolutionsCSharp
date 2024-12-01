using Solutions;

namespace LeetcodeSolutionsCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(2);
            ListNode l2 = new ListNode(4);
            ListNode l3 = new ListNode(3);
            l1.next = l2;
            l2.next = l3;
            ListNode r1 = new ListNode(5);
            ListNode r2 = new ListNode(6);
            ListNode r3 = new ListNode(4);
            r1.next = r2;
            r2.next = r3;
            Solution0002 s1 = new Solution0002();
            var result = s1.AddTwoNumbers(l1, r1);
        }
    }
}
