using System;

namespace _19._Remove_Nth_Node_From_End_of_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

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

    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode temp = new ListNode(0, head);
            ListNode fast = temp;
            ListNode slow = temp;

            for (int i = 0; i < n; i++)
            {
                fast = fast.next;
            }
            
            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            slow.next = slow.next.next;

            return temp.next;
        }
    }
}
