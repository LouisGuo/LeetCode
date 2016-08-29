using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MaximumDepthofBinaryTree
    {
        public int Solution(TreeNode root)
        {
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
                return 1;
            var leftMax = 1 + (root.left == null ? 0 : Solution(root.left));
            var rightMax = 1 + (root.right == null ? 0 : Solution(root.right));
            return leftMax > rightMax ? leftMax : rightMax;
        }

        public class TreeNode
        {
            public int val;

            public TreeNode left;

            public TreeNode right;

            public TreeNode(int x)
            {
                val = x;
            }
        }
    }


}
