using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BinaryTreeInorderTraversal
    {
        public IList<int> Solution(TreeNode root)
        {
            var result = new List<int>();
            if (root != null)
            {
                if (root.left != null)
                    result.AddRange(Solution(root.left));
                result.Add(root.val);
                if (root.right != null)
                    result.AddRange(Solution(root.right));
            }
            return result;
        }
    }
}
