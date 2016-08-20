using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SwapNodesinPairs
    {
        public ListNode Sollution(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            var current = head;
            head = head.next;
            current.next = head.next;
            head.next = current;
            var temp = default(ListNode);
            while (current.next != null && current.next.next != null)
            {
                temp = current.next;
                current.next = current.next.next;
                temp.next = temp.next.next;
                current.next.next = temp;
                current = current.next.next;
            }
            return head;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
