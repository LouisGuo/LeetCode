using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidateBinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {
            if (root != null)
            {
                return Valid(root, double.MinValue, double.MaxValue);
            }
            return true;
        }

        private bool Valid(TreeNode root, double min, double max)
        {
            if (root.val >= max || root.val <= min)
                return false;
            else
            {
                var left = true;
                if (root.left != null)
                    left = Valid(root.left, min, root.val);
                var right = true;
                if (root.right != null)
                    right = Valid(root.right, root.val, max);
                return left && right;
            }
        }

    }
}
