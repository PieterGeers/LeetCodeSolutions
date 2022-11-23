using System;

namespace _2._Add_Two_Numbers
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
    
        public ListNode(int val=0, ListNode next=null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode temp = new ListNode();
            ListNode head = temp;

            int sum = 0;
            while (l1 != null || l2 != null || sum != 0)
            {
                sum += (l1?.val ?? 0) + (l2?.val ?? 0);
                temp.next = new ListNode(sum % 10);
                sum /= 10;

                l1 = l1?.next;
                l2 = l2?.next;

                temp = temp.next;
            }
            
            return head.next;
        }
    }
}
