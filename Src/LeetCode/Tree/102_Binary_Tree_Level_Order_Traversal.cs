using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var nodeList = new List<List<TreeNode>>();
            if (root != null)
            {
                nodeList.Add(new List<LeetCode.TreeNode>() { root });
                while (nodeList[nodeList.Count - 1].Count > 0)
                {
                    var tempList = new List<TreeNode>();
                    foreach (var node in nodeList[nodeList.Count - 1])
                    {
                        if (node.left != null)
                            tempList.Add(node.left);
                        if (node.right != null)
                            tempList.Add(node.right);
                    }
                    if (tempList.Count > 0)
                        nodeList.Add(tempList);
                    else
                        break;
                }
            }
            return nodeList.Select(nodes => (IList<int>)nodes.Select(node => node.val).ToList()).ToList();
        }
    }
}
