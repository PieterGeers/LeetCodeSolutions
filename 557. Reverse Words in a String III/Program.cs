using System;

namespace _557._Reverse_Words_in_a_String_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            string result = s.ReverseWords("I love u");

            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public string ReverseWords(string s)
        {
            int length = s.Length;
            int lastIdx = length - 1;
            char[] result = s.ToCharArray();
            int left = 0;
            int right = length - 1;

            for (int i = 0; i < length; i++)
            {
                if (s[i] == ' ' || i == lastIdx)
                {
                    right = i == lastIdx ? i : i - 1;
                    while (left < right)
                    {
                        (result[left], result[right]) = (s[right--], s[left++]);
                    }
                    left = ++i;
                }
            }

            return new string(result);
        }
    }
}
