using System;
using System.Collections.Generic;

namespace _189._Rotate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            int[] test = new[] { 1, 2, 3, 4, 5, 6, 7 };
            s.Rotate(test, 10);

            foreach (int i in test)
            {
                Console.Write($"{i}, ");
            }
        }
    }

    public class Solution
    {
        //public void Rotate(int[] nums, int k)
        //{
        //    LinkedList<int> list = new LinkedList<int>(nums);

        //    for (int i = 0; i < k; i++)
        //    {
        //        LinkedListNode<int> mark = list.Last;
        //        list.RemoveLast();
        //        list.AddFirst(mark);
        //    }

        //    list.CopyTo(nums, 0);
        //}

        public void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            int[] result = new int[nums.Length];
            Array.Copy(nums, nums.Length - k, result, 0, k);
            Array.Copy(nums, 0, result, k, nums.Length - k);
            result.CopyTo(nums, 0);
        }

        //public void Rotate(int[] nums, int k)
        //{
        //    int length = nums.Length;
        //    k %= length;
        //    int[] result = new int[length];
        //    for (int i = 0; i < length; i++)
        //    {
        //        result[(i + k) % length] = nums[i];
        //    }
        //    result.CopyTo(nums, 0);
        //}
    }
}
