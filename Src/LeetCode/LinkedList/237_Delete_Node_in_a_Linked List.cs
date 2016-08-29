using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class DeleteNodeinaLinkedList
    {
        public void Solution(ListNode node)
        {
            if (node == null || node.next == null)
                return;
            node.val = node.next.val;
            node.next = node.next.next;
        }
        
    }
}
