﻿using System;

namespace _116._Populating_Next_Right_Pointers_in_Each_Node
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

    public class Solution
    {
        public Node Connect(Node root)
        {
            if (root == null)
                return null;
            if (root.left != null) 
                root.left.next = root.right;
            if (root.right != null && root.next != null) 
                root.right.next = root.next.left;
            Connect(root.left);
            Connect(root.right);
            return root;
        }
    }
}
