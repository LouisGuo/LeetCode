using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BinaryTreePreorderTraversal
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            if (root != null)
            {
                result.Add(root.val);
                if (root.left != null)
                    result.AddRange(PreorderTraversal(root.left));
                if (root.right != null)
                    result.AddRange(PreorderTraversal(root.right));
            }
            return result;
        }
    }
}
