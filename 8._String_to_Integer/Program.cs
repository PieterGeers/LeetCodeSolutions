using System;

namespace _8._String_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var result = s.MyAtoi("42");
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public int MyAtoi(string s)
        {
            int i = 0, l = s.Length;
            int result = 0;
            sbyte sign = 0;

            if (l == 0) return result;

            while (i < l && s[i] == ' ')
            {
                i++;
                continue;
            }

            if (i < l)
            {
                if (s[i] == '+') { sign = 1; i++; }
                else if (s[i] == '-') { sign = -1; i++; }
                else sign = 1;
            }

            char c = s[Math.Min(l - 1, i)];
            while (i < l && c >= '0' && c <= '9')
            { 
                try
                {
                    result = checked((result * 10) + (c - '0'));
                }
                catch (OverflowException)
                {
                    return sign < 0 ? int.MinValue : int.MaxValue;
                }
                c = s[Math.Min(l - 1, ++i)];
            }

            sign = sign == 0 ? (sbyte)1 : sign;
            return sign * result;
        }
    }
}
