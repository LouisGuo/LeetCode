using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class InvertBinaryTree
    {
        public TreeNode Sollution(TreeNode root)
        {
            if (root == null)
                return null;
            var temp = root.left;
            root.left = Sollution(root.right);
            root.right = Sollution(temp);
            return root;
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
