using System;

namespace _7._Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.Reverse(-123);
        }
    }

    public class Solution
    {
        public int Reverse(int x)
        {
            int reverse = 0;
            try
            {
                while (x != 0)
                {
                    reverse = checked(reverse * 10 + x % 10);
                    x /= 10;
                }
            }
            catch (OverflowException e)
            {
                return 0;
            }


            return reverse;
        }
    }
}
