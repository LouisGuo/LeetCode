﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class InvertBinaryTree
    {
        public TreeNode Solution(TreeNode root)
        {
            if (root == null)
                return null;
            var temp = root.left;
            root.left = Solution(root.right);
            root.right = Solution(temp);
            return root;
        }
    }
}
