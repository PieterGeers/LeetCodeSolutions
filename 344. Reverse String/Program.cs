using System;

namespace _344._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            char[] t = new[] { 'h', 'e', 'l', 'l', 'o', 'o' };
            s.ReverseString(t);

            foreach (char c in t)
            {
                Console.Write($"{c}, ");
            }
        }
    }

    public class Solution
    {
        //public void ReverseString(char[] s)
        //{
        //    int left = 0;
        //    int right = s.Length - 1;

        //    char temp;
        //    while (left < right)
        //    {
        //        temp = s[left];
        //        s[left++] = s[right];
        //        s[right--] = temp;
        //    }
        //}

        public void ReverseString(char[] s)
        {
            for (int i = 1; i <= s.Length / 2; i++)
            {
                (s[i - 1], s[^i]) = (s[^i], s[i - 1]);
            }
        }
    }
}
