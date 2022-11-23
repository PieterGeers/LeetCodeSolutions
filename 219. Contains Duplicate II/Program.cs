using System;
using System.Collections.Generic;

namespace _219._Contains_Duplicate_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var result = s.ContainsNearbyDuplicate(new[] { 1, 0, 1, 1 }, 1);
        }
    }

    public class Solution
    {
        //#region TimeLimitExceeded
        //public bool ContainsNearbyDuplicate(int[] nums, int k)
        //{
        //    int numI = 0;
        //    for (int i = 0, j; i < nums.Length - 1; i++)
        //    {
        //        numI = nums[i];
        //        for (j = i + 1; j < nums.Length; j++)
        //        {
        //            if (numI == nums[j] && Math.Abs(i - j) <= k)
        //            {
        //                return true;
        //            }
        //        }
        //    }

        //    return false;
        //}
        //#endregion

        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> temp = new Dictionary<int, int>();
            int num;
            for (int i = 0; i < nums.Length; i++)
            {
                num = nums[i];
                if (temp.TryGetValue(num, out int value) && i - value <= k)
                {
                    return true;
                }
                
                temp[num] = i;
            }

            return false;
        }
    }
}
