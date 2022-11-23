using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            var result = s.TwoSum(new[] { 2, 7, 11, 15 }, 26);
            Console.WriteLine($"[{result[0]}, {result[1]}]");
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            List<int> l = nums.ToList();
            int idx = l.Count - 1;
            int idxNum = l[idx];

            while (l.Count > 2)
            {
                l.RemoveAt(idx);
                if (l.Exists(i => target - idxNum == i))
                {
                    int idx2 = l.FindIndex(i => target - idxNum == i);
                    return new[] { idx2, idx };
                }

                idx -= 1;
                idxNum = l[idx];
            }

            return new[] { 0, 1 };
        }
    }
}
