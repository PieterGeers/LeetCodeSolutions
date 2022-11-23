using System;

namespace _76._Minimum_Window_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var result = s.MinWindow("ADOBECODEBANC", "ABC");
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public string MinWindow(string s, string t)
        {
            if (t.Length > s.Length)
            {
                return string.Empty;
            }

            int[] lookup = new int[58];
            int count = 0;

            foreach (char c in t)
            {
                if (lookup[c - 'A']++ == 0) count++;
            }

            int left = 0, right = 0;
            int sLength = s.Length;
            string result = string.Empty;
            
            while (right < sLength || count == 0)
            {
                if (count > 0)
                {
                    if (lookup[s[right++] - 'A']-- == 1) count--;
                }
                else
                {
                    if (lookup[s[left++] - 'A']++ == 0) count++;
                    
                    if (count > 0 && (result.Length == 0 || result.Length > right - (left - 1)))
                    {
                        result = s.Substring(left - 1, right - (left - 1));
                    }
                }
            }

            return result;
        }
    }
}
