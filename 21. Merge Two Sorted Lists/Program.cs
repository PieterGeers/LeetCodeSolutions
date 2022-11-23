using System;

namespace _21._Merge_Two_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class ListNode 
    {
        public int val;
        public ListNode next;

        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1; 

            ListNode resultHead = new ListNode();
            ListNode temp = resultHead;
            while (list1 != null && list2 != null) 
            {
                if (list1.val <= list2.val)
                {
                    temp.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    temp.next = list2;
                    list2 = list2.next;
                }
                temp = temp.next;
            }

            temp.next = list1 ?? list2;

            return resultHead.next;
        }
    }
}
