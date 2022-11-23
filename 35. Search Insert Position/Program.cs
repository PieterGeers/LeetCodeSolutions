using System;

namespace _35._Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            var result = s.SearchInsert(new[] { 1, 3, 5, 6 }, 5);
        }
    }

    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums[0] >= target)
            {
                return 0;
            }

            if (nums[nums.Length - 1] <= target)
            {
                return nums[nums.Length - 1] == target ? nums.Length - 1 : nums.Length;
            }

            int min = 1;
            int max = nums.Length - 2;

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

            return min;
        }
    }
}
