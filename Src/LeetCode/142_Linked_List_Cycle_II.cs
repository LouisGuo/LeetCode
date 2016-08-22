using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LinkedListCycleII
    {
        public ListNode Sollution(ListNode head)
        {
            if (head != null)
            {
                var set = new HashSet<ListNode>();
                var current = head;
                while (current != null)
                {
                    if (set.Contains(current))
                    {
                        return current;
                    }
                    set.Add(current);
                    current = current.next;
                }
            }
            return null;
        }

        public ListNode Sollution_Fast(ListNode head)
        {
            if (head != null)
            {
                if (head.next == head)
                    return head;
                var current = head;
                var pre = default(ListNode);
                while (IsCycle(current))
                {
                    pre = current;
                    current = current.next;
                    pre.next = null;
                }
                if (current != head)
                {
                    pre.next = current;
                    return pre;
                }
            }
            return null;
        }

        public bool IsCycle(ListNode head)
        {
            if (head == null)
                return false;
            var slow = head;
            var fast = head.next;
            while (slow != fast)
            {
                if (fast == null || fast.next == null)
                    return false;
                slow = slow.next;
                fast = fast.next.next;
            }
            return true;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
    }
}
