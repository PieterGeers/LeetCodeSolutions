using System;

namespace _9._Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var result = s.IsPalindrome(121);
            Console.WriteLine($"{result}");
        }
    }

    public class Solution
    {
        /*public bool IsPalindrome(int x)
        {
            string temp = $"{x}";

            int left = 0;
            int right = temp.Length - 1;

            while (left < right)
            {
                if (temp[left++] != temp[right--])
                {
                    return false;
                }
            }

            return true;
        }*/

        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0)) return false;

            int temp = 0;
            while (x > temp)
            {
                temp = temp * 10 + x % 10;
                x /= 10;
            }

            return x == temp || x == temp / 10;
        }
    }
}
