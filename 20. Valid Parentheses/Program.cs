using System;
using System.Collections.Generic;

namespace _20._Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var result = s.IsValid("([]{}");
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        //public bool IsValid(string s)
        //{
        //    string openLookup = "[({";
        //    string closedLookup = "])}";

        //    Stack<int> container = new Stack<int>();
        //    int pop;
        //    foreach (char c in s)
        //    {
        //        if (openLookup.Contains(c))
        //        {
        //            container.Push(openLookup.IndexOf(c));
        //            continue;
        //        }

        //        if (container.Count == 0) return false;

        //        pop = container.Pop();
        //        if (pop == closedLookup.IndexOf(c))
        //        {
        //            continue;
        //        }

        //        return false;
        //    }

        //    return container.Count == 0;
        //}

        public bool IsValid(string s)
        {
            Dictionary<char, char> lookup = new Dictionary<char, char>();
            lookup.Add('[', ']');
            lookup.Add('{', '}');
            lookup.Add('(', ')');

            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (lookup.ContainsKey(c)) { stack.Push(lookup[c]); }
                else if (stack.Count == 0 || stack.Pop() != c) return false;
            }

            return stack.Count == 0;
        }
    }
}
