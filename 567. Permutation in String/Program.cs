using System;
using System.Collections;
using System.Collections.Generic;

namespace _567._Permutation_in_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var result = s.CheckInclusion("aabc", "zgbaac");
            Console.WriteLine($"{result}");
        }
    }

    public class Solution
    {
        /*#region Dictionary
        public bool CheckInclusion(string s1, string s2)
        {
            int s1Length = s1.Length;
            Dictionary<char, int> s1Dictionary = new Dictionary<char, int>();
            CreateDictionary(ref s1Dictionary, s1);

            int loops = s2.Length - s1Length;
            Dictionary<char, int> tempDictionary = new Dictionary<char, int>();
            string tempString = "";
            for (int i = 0; i <= loops; i++)
            {
                tempString = s2.Substring(i, s1Length);
                CreateDictionary(ref tempDictionary, tempString);

                if (AreEqual(s1Dictionary, tempDictionary))
                {
                    return true;
                }
            }

            return false;
        }

        private bool AreEqual(Dictionary<char, int> d1, Dictionary<char, int> d2)
        {
            foreach (KeyValuePair<char, int> pair in d1)
            {
                if (!d2.ContainsKey(pair.Key))
                {
                    return false;
                }

                if (d2[pair.Key] != pair.Value)
                {
                    return false;
                }
            }

            return true;
        }

        private void CreateDictionary(ref Dictionary<char, int> d, string s)
        {
            d.Clear();
            foreach (char c in s)
            {
                if (!d.ContainsKey(c))
                {
                    d.Add(c, 1);
                    continue;
                }
                d[c] += 1;
            }
        }
        #endregion*/

        /*#region sliding window
        public bool CheckInclusion(string s1, string s2)
        {
            int s1Length = s1.Length;
            int s2Length = s2.Length;

            if (s1Length > s2Length)
            {
                return false;
            }

            int[] original = new int[26];
            int[] check = new int[26];

            foreach (char c in s1)
            {
                original[c - 'a']++;
            }

            for (int i = 0; i < s1Length; i++)
            {
                check[s2[i] - 'a']++;
            }

            if (AreEqual(original, check, original.Length))
            {
                return true;
            }

            for (int right = s1Length; right < s2Length; right++)
            {
                check[s2[right] - 'a']++;
                check[s2[right - s1Length] - 'a']--;

                if (AreEqual(original, check, 26))
                {
                    return true;
                }
            }

            return false;
        }

        private bool AreEqual(int[] a1, int[] a2, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (a1[i] != a2[i])
                {
                    return false;
                }
            }

            return true;
        }
#endregion*/

        public bool CheckInclusion(string s1, string s2)
        {
            int[] values = new int[26];
            int count = 0;
            int index = 0;

            foreach (char c in s1)
            {
                if (values[c - 'a']++ == 0) count++;
            }

            int right = 0;
            int s1Length = s1.Length;
            int s2Length = s2.Length;
            while (right < s2Length)
            {
                index = s2[right] - 'a';
                values[index]--;
                if (values[index] == 0) count--;
                else if (values[index] == -1) count++;

                if (right >= s1Length)
                {
                    index = s2[right - s1Length] - 'a';
                    values[index]++;
                    if (values[index] == 0) count--;
                    else if (values[index] == 1) count++;
                }

                right++;
                if (count == 0)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
