using System.Numerics;
using System.Text;

namespace Solutions._1_99
{
    internal class _02_AddTwoNumbers
    {
        public _02_AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = AddTwoNumbers(l1, l2);

            Console.WriteLine(result.ToString());
        }

        private ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode tail = dummyHead;
            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                int n1 = l1?.val ?? 0;
                int n2 = l2?.val ?? 0;

                int sum = (n1 + n2 + carry);
                carry = sum / 10;

                tail.next = new ListNode(sum % 10);
                tail = tail.next;

                l1 = l1?.next;
                l2 = l2?.next;
            }

            return dummyHead.next;
        }
    }

    internal sealed class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public override string ToString()
        {
            ListNode node = this;

            string result = string.Empty;

            while (node?.val != null)
            {
                result = string.IsNullOrEmpty(result) ? $"{node.val}" : $"{result}, {node.val}";
                node = node.next;
            }

            return result;
        }
    }
}