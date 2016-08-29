using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.MaximumDepthofBinaryTree;

namespace LeetCode.Tests
{
    [TestClass]
    public class MaximumDepthofBinaryTreeTests
    {
        [TestMethod]
        public void SolutionTest()
        {
            var tool = new MaximumDepthofBinaryTree();
            var treeNode = new TreeNode(1);
            treeNode.left = new TreeNode(2);
            treeNode.right = new TreeNode(3);
            treeNode.left.left = new TreeNode(4);
            treeNode.left.left.left = new TreeNode(5);
            treeNode.left.left.right = new TreeNode(5);
            treeNode.right.left = new TreeNode(4);
            treeNode.right.left.left = new TreeNode(5);
            treeNode.right.left.right = new TreeNode(5);
            treeNode.right.left.right = new TreeNode(5);
            treeNode.right.left.right.right = new TreeNode(5);
            var result = tool.Solution(treeNode);
            Assert.AreEqual(3, result);
        }
    }
}