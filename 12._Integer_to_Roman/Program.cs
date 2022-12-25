using System;
using System.Text;
using System.Collections.Generic;

namespace _12._Integer_to_Roman
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var result = s.IntToRoman(3999);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        static Dictionary<int, string> lookup = new()
        {
            {1, "I"}, {2, "II"}, {3, "III"}, {4, "IV"}, {5, "V"},
            {9, "IX"}, {10, "X"}, {20, "XX"}, {30, "XXX"}, {40, "XL"}, {50, "L"},
            {90, "XC"}, {100, "C"}, {200, "CC"}, {300, "CCC"}, {400, "CD"}, {500, "D"},
            {900, "CM"}, {1000, "M"}, {2000, "MM"}, {3000, "MMM"},
        };

        public string IntToRoman(int num)
        {
            string result = string.Empty;


            for (int i = 10; i <= 10000; i*=10)
            {
                int temp = num % i;
                if (temp == 0) continue;
                
                if (lookup.ContainsKey(temp))
                {
                    result = $"{lookup[temp]}{result}";
                }
                else
                {
                    result = $"{lookup[i / 2]}{lookup[temp % (i / 2)]}{result}";
                }

                num = (num / i) * i;
            }

            return result;
        }
    }
}
