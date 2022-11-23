using System;

namespace _283._Move_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            int[] test = new[] { 0, 1, 0, 3, 12 };
            s.MoveZeroes(test);

            foreach (int i in test)
            {
                Console.Write($"{i}, ");
            }

        }
    }

    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int pointer = 0;
            int length = nums.Length;
            for (int i = 0; i < length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[pointer++] = nums[i];
                }
            }

            while (pointer < length)
            {
                nums[pointer++] = 0;
            }
        }

        //public void MoveZeroes(int[] nums)
        //{
        //    int pointer = 0;
        //    int idx = -1;
        //    while (idx++ < nums.Length - 1)
        //    {
        //        if (nums[idx] != 0)
        //        {
        //            nums[pointer++] = nums[idx];
        //        }

        //    }

        //    while (pointer < nums.Length)
        //    {
        //        nums[pointer++] = 0;
        //    }
        //}
    }
}
