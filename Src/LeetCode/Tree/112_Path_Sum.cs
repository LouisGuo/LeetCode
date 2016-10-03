using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PathSum
    {
        public bool Solution(TreeNode root, int sum)
        {
            return root == null ? false : Matchs(root, sum, 0);
        }

        private bool Matchs(TreeNode root, int sum, int currentSum)
        {
            if (root.left == null)
            {
                if (root.right == null)
                    return root.val + currentSum == sum;
                else
                    return Matchs(root.right, sum, currentSum + root.val);
            }
            else
            {
                if (root.right == null)
                    return Matchs(root.left, sum, currentSum + root.val);
                else
                    return Matchs(root.left, sum, currentSum + root.val)
                        || Matchs(root.right, sum, currentSum + root.val);
            }
        }

        public bool Solution_Simple(TreeNode root, int sum)
        {
            if (root != null)
            {
                if (root.left == null && root.right == null)
                {
                    return root.val == sum;
                }
                else if (root.left == null && root.right != null)
                {
                    return Solution_Simple(root.right, sum - root.val);
                }
                else if (root.left != null && root.right == null)
                {
                    return Solution_Simple(root.left, sum - root.val);
                }
                else
                {
                    return Solution_Simple(root.right, sum - root.val)
                        || Solution_Simple(root.left, sum - root.val);
                }
            }
            return false;
        }
    }
}
