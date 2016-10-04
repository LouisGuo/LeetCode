using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MinimumDepthofBinaryTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
                return 1;
            else if (root.left != null && root.right == null)
            {
                return 1 + MinDepth(root.left);
            }
            else if (root.left == null && root.right != null)
            {
                return 1 + MinDepth(root.right);
            }
            else
                return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
        }
    }
}
