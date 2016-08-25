using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveLinkedListElements
    {
        public ListNode Sollution(ListNode head, int val)
        {
            while (head != null && head.val == val)
            {
                var temp = head;
                head = head.next;
                temp.next = null;
            }
            var current = head;
            while (current != null && current.next != null)
            {
                if (current.next.val == val)
                    current.next = current.next.next;
                else
                    current = current.next;
            }
            return head;
        }
        
    }
}
