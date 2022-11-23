using System;

namespace _617._Merge_Two_Binary_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            TreeNode root1 = new TreeNode(1, new TreeNode(3, new TreeNode(5), null), new TreeNode(2, null, null));
            TreeNode root2 = new TreeNode(2, new TreeNode(1, null, new TreeNode(4, null, null)),
                new TreeNode(3, null, new TreeNode(7, null, null)));

            var result = s.MergeTrees(root1, root2);
        }
    }

    public class TreeNode 
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    
    public class Solution
    {
        /*public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null) return root2;
            if (root2 == null) return root1;

            TreeNode resultHead = new TreeNode(root1.val + root2.val, null, null);
            MergeLeftNode(resultHead, root1, root2);
            MergeRightNode(resultHead, root1, root2);

            return resultHead;
        }

        private void MergeLeftNode(TreeNode resultNode, TreeNode parent1, TreeNode parent2)
        {
            switch (parent1.left)
            {
                case null when parent2.left == null:
                    return;
                case null:
                    resultNode.left = parent2.left;
                    return;
            }

            if (parent2.left == null)
            {
                resultNode.left = parent1.left;
                return;
            }

            resultNode.left = new TreeNode(parent1.left.val + parent2.left.val, null, null);
            MergeLeftNode(resultNode.left, parent1.left, parent2.left);
            MergeRightNode(resultNode.left, parent1.left, parent2.left);
        }

        private void MergeRightNode(TreeNode resultNode, TreeNode parent1, TreeNode parent2)
        {
            switch (parent1.right)
            {
                case null when parent2.right == null:
                    return;
                case null:
                    resultNode.right = parent2.right;
                    return;
            }

            if (parent2.right == null)
            {
                resultNode.right = parent1.right;
                return;
            }

            resultNode.right = new TreeNode(parent1.right.val + parent2.right.val, null, null);
            MergeLeftNode(resultNode.right, parent1.right, parent2.right);
            MergeRightNode(resultNode.right, parent1.right, parent2.right);
        }*/

        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null) return root2;
            if (root2 == null) return root1;

            TreeNode result = new TreeNode(root1.val + root2.val); 
            result.left = MergeTrees(root1.left, root2.left);
            result.right = MergeTrees(root1.right, root2.right);
            return result;
        }
    }
}
