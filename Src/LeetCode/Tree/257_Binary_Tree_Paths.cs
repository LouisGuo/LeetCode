using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BinaryTreePaths
    {
        private IList<string> result = new List<string>();

        public IList<string> Solution(TreeNode root)
        {
            if (root != null)
                Matchs(root, "");
            return result;
        }

        private void Matchs(TreeNode root, string currentList)
        {
            currentList = currentList.Equals("") ? root.val + ""
                : currentList + "->" + root.val;
            if (root.left == null)
            {
                if (root.right == null)
                {
                    result.Add(currentList);
                }
                else
                {
                    Matchs(root.right, currentList);
                }
            }
            else
            {
                if (root.right == null)
                    Matchs(root.left, currentList);
                else
                {
                    Matchs(root.right, currentList);
                    Matchs(root.left, currentList);
                }
            }
        }
    }
}
