using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BinaryTreeLevelOrderTraversalII
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            var nodeList = new List<List<TreeNode>>();
            if (root != null)
            {
                nodeList.Add(new List<TreeNode>() { root });
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
            nodeList.Reverse();
            return nodeList.Select(nodes => (IList<int>)nodes.Select(node => node.val).ToList()).ToList();
        }
    }
}
