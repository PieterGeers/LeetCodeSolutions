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
        public string IntToRoman(int num)
        {
            string result = string.Empty;
            Dictionary<int, string> lookup = new Dictionary<int, string>();
            lookup.Add(1, "I");
            lookup.Add(2, "II");
            lookup.Add(3, "III");
            lookup.Add(4, "IV");
            lookup.Add(5, "V");

            lookup.Add(9, "IX");
            lookup.Add(10, "X");
            lookup.Add(20, "XX");
            lookup.Add(30, "XXX");
            lookup.Add(40, "XL");
            lookup.Add(50, "L");

            lookup.Add(90, "XC");
            lookup.Add(100, "C");
            lookup.Add(200, "CC");
            lookup.Add(300, "CCC");
            lookup.Add(400, "CD");
            lookup.Add(500, "D");

            lookup.Add(900, "CM");
            lookup.Add(1000, "M");
            lookup.Add(2000, "MM");
            lookup.Add(3000, "MMM");

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
