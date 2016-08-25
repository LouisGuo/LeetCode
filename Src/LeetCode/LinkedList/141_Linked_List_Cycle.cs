using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LinkedListCycle
    {
        public bool Sollution(ListNode head)
        {
            if (head == null)
                return false;
            var set = new HashSet<ListNode>();
            var current = head;
            while (current != null)
            {
                if (set.Contains(current))
                    return true;
                else
                    set.Add(current);
                current = current.next;
            }
            return false;
        }

        public bool Sollution_Fast(ListNode head)
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

        public bool Sollution_Faster(ListNode head)
        {
            if (head == null)
                return false;
            var reversedHead = Reverse(head);
            Reverse(reversedHead);
            return head.next != null && head.Equals(reversedHead);
        }

        public ListNode Reverse(ListNode head)
        {
            if (head != null)
            {
                var rest = head.next;
                head.next = null;
                while (rest != null)
                {
                    var temp = rest.next;
                    rest.next = head;
                    head = rest;
                    rest = temp;
                }
            }
            return head;
        }
    }
}
