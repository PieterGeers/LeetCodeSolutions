using System;

namespace _278._First_Bad_Version
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution //: VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int min = 0;
            int max = n;

            while (min <= max)
            {
                int mid = min + (max - min) / 2;
                if (IsBadVersion(mid))
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return max + 1;
        }

        private bool IsBadVersion(int n)
        {
            return true;
        }
    }
}
