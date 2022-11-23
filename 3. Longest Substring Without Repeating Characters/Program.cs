using System;
using System.Collections.Generic;

namespace _3._Longest_Substring_Without_Repeating_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var result = s.LengthOfLongestSubstring("bbb");
            Console.WriteLine($"{result}");
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int length = s.Length;

            int result = 0;
            char temp = ' ';

            for (int i = 0, substrLength = 0; i < length; i++)
            {
                temp = s[i];

                for (int j = i - substrLength; j < i; j++)
                {
                    if (s[j] == temp)
                    {
                        substrLength = i - (j + 1);
                    }
                }

                substrLength++;

                result = Math.Max(result, substrLength);
            }

            return result;
        }
    }
}
