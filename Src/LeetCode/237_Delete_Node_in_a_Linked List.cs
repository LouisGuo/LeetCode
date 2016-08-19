﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class DeleteNodeinaLinkedList
    {
        public void Sollution(ListNode node)
        {
            if (node == null || node.next == null)
                return;
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}