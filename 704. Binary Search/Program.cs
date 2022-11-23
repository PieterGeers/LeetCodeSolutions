using System;
using System.Xml.Schema;

namespace _704._Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            var result = s.Search(new[] { 0, 1 }, 1);
            Console.WriteLine($"{result}");
        }
    }

    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int min = 0;
            int max = nums.Length - 1;

            while (min <= max)
            {
                int mid = min + (max - min) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] < target)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }

            return -1;
        }

        private int FindTargetIndex(int[] nums, int minIdx, int maxIdx, int target)
        {
            int midIdx = minIdx + ((maxIdx - minIdx) / 2);
            int midNum = nums[midIdx];
            
            if (midNum == target)
            {
                return midIdx;
            }

            if (midIdx == minIdx)
            {
                return nums[maxIdx] == target ? maxIdx : -1;
            }

            if (midNum > target)
            {
                return FindTargetIndex(nums, minIdx, midIdx, target);
            }

            return FindTargetIndex(nums, midIdx, maxIdx, target);
        }
    }
}
