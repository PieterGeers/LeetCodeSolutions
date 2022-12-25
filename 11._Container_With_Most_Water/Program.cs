using System;

namespace _11._Container_With_Most_Water
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var intArr = new int[]{ 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var result = s.MaxArea(intArr);
            Console.WriteLine(result);
        }
    }

    //brute force [Time limit exceeded]
    /*public class Solution
    {
        public int MaxArea(int[] height)
        {
            int l = height.Length;
            int result = 0;

            for (int i = 0, j; i < l - 1; i++)
            {
                int left = height[i];
                for (j = i + 1; j < l; j++)
                {
                    result = Math.Max(result, (j - i) * Math.Min(left, height[j]));
                }
            }

            return result;
        }
    }*/

    public class Solution
    {
        public int MaxArea(int[] height)
        {
            if (height.Length == 0) return 0;
            if (height.Length == 1) return height[0];

            int l = 0, r = height.Length - 1;
            int result = 0;

            while (l < r)
            {
                result = Math.Max(result, Math.Min(height[l], height[r]) * (r - l));
                if (height[l] < height[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }

            return result;
        }
    }
}
