﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SameTree
    {
        public bool Solution(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            else if (p != null && q != null)
            {
                if (p.val == q.val)
                    return Solution(p.left, q.left) && Solution(p.right, q.right);
                return false;
            }
            else
                return false;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }

    
}
