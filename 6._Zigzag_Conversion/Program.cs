using System;
using System.Text;

namespace _6._Zigzag_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            var result = s.Convert("PAYPALISHIRING", 3);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            StringBuilder result = new StringBuilder();
            int l = s.Length;
            int pos = 0;
                        
            for (int i = 0; i < numRows; i++)
            {
                int offset2 = i * 2;
                int offset1 = ((numRows - 1) * 2) - offset2;

                pos = i;
                if (pos < l)
                {
                    result.Append(s[pos]);
                }

                while (pos < l)
                {
                    if (offset1 > 0 && (pos += offset1) < l)
                    {
                        result.Append(s[pos]);
                    }
                    if (offset2 > 0 && (pos += offset2) < l)
                    {
                        result.Append(s[pos]);
                    }
                }
            }

            return result.ToString();
        }
    }
}
