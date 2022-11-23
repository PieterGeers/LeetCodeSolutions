using System;

namespace _167._Two_Sum_II___Input_Array_Is_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            var result = s.TwoSum(new[] { -1000, -1, 0, 1 }, 1);
            Console.WriteLine($"[{result[0]}, {result[1]}]");
        }
    }

    public class Solution
    {
        //public int[] TwoSum(int[] numbers, int target)
        //{
        //    int length = numbers.Length;
        //    int j = 0;
        //    int numJ = numbers[j];
        //    for (int i = length - 1; i > 0; i--)
        //    {
        //        if (numbers[i] + numJ > target)
        //        {
        //            continue;
        //        }

        //        if (numbers[i++] + numJ < target)
        //        {
        //            numJ = numbers[++j];
        //            continue;
        //        }

        //        return new []{j+1, i};
        //    }

        //    return new[] { 1, 2 };
        //}

        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                if (numbers[right] + numbers[left] > target)
                {
                    right--;
                    continue;
                }

                if (numbers[right] + numbers[left] < target)
                {
                    left++;
                    continue;
                }

                break;
            }

            return new[] { left + 1, right + 1};
        }
    }

    //public int[] TwoSum(int[] numbers, int target)
    //{
    //    int[] RetValue = default;
    //    int left = 0;
    //    int right = numbers.Length - 1;

    //    while (left < right)
    //    {
    //        if (numbers[left] + numbers[right] == target) return new int[] { left + 1, right + 1 };
    //        if (numbers[left] + numbers[right] < target) left++;
    //        if (numbers[left] + numbers[right] > target) right--;
    //    }

    //    return RetValue;
    //}
}
