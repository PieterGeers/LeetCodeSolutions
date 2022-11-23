using System;
using System.Linq;
using System.Text;

namespace _14._Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string[] input = new[] { "flower", "flow", "flight" };
            var result = s.LongestCommonPrefix(input);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            StringBuilder result = new StringBuilder();

            int length = strs.Min(s => s.Length);
            int count = strs.Length;
            char c;
            for (int i = 0, j = 0; i < length; i++)
            {
                c = strs[0][i];
                for (j = 0; j < count; j++)
                {
                    if (strs[j][i] != c) return result.ToString();
                }
                result.Append(c);
            }

            return result.ToString();
        }
    }
}
