using System;

namespace _977._Squares_of_a_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            var result = s.SortedSquares(new[] { -4, -1, 0, 3, 10 });

            foreach (int i in result)
            {
                Console.Write($"{i}, ");
            }
        }
    }

    public class Solution
    {
        //public int[] SortedSquares(int[] nums)
        //{
        //    int[] result = new int[nums.Length];

        //    int posIdx = 0;

        //    while (posIdx < nums.Length - 1)
        //    {
        //        if (nums[posIdx] < 0)
        //        {
        //            posIdx += 1;
        //            continue;
        //        }

        //        break;
        //    }

        //    int negIdx = posIdx - 1;

        //    int posPower = nums[posIdx] * nums[posIdx];
        //    int negPower = negIdx < 0 ? int.MaxValue : nums[negIdx] * nums[negIdx];
        //    int i = 0;
        //    while (i < nums.Length)
        //    {
        //        if (posPower <= negPower)
        //        {
        //            result[i] = posPower;
        //            posIdx += 1;
        //            posPower = posIdx < nums.Length ? nums[posIdx] * nums[posIdx] : int.MaxValue;
        //        }
        //        else
        //        {
        //            result[i] = negPower;
        //            negIdx -= 1;
        //            negPower = negIdx < 0 ? int.MaxValue : nums[negIdx] * nums[negIdx];
        //        }

        //        i += 1;
        //    }

        //    return result;
        //}

        public int[] SortedSquares(int[] nums)
        {
            var arr = new int[nums.Length];
            int begIndex = 0;
            int endIndex = nums.Length - 1;
            int end = endIndex;
            while (begIndex <= endIndex)
                arr[end--] = Math.Abs(nums[endIndex]) > Math.Abs(nums[begIndex])
                    ? nums[endIndex] * nums[endIndex--]
                    : nums[begIndex] * nums[begIndex++];
            return arr;
        }
    }
}
