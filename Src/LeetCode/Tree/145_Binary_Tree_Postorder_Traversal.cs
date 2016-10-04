using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BinaryTreePostorderTraversal
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            if (root != null)
            {
                if (root.left != null)
                    result.AddRange(PostorderTraversal(root.left));
                if (root.right != null)
                    result.AddRange(PostorderTraversal(root.right));
                result.Add(root.val);
            }
            return result;
        }
    }
}
