using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PathSumII
    {
        private IList<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> Solution(TreeNode root, int sum)
        {
            if (root != null)
                Matchs(root, sum, new List<int>());
            return result;
        }

        private void Matchs(TreeNode root, int sum, List<int> currentList)
        {
            currentList.Add(root.val);
            if (root.left == null)
            {
                if (root.right == null)
                {
                    if (root.val == sum)
                    {
                        result.Add(currentList);
                    }
                }
                else
                {
                    Matchs(root.right, sum - root.val, currentList);
                }
            }
            else
            {
                if (root.right == null)
                    Matchs(root.left, sum - root.val, currentList);
                else
                {
                    var tempList = new List<int>();
                    tempList.AddRange(currentList);
                    Matchs(root.right, sum - root.val, currentList);
                    Matchs(root.left, sum - root.val, tempList);
                }
            }
        }
    }
}
