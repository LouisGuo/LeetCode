using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveDuplicatesfromSortedListII
    {
        public ListNode Solution(ListNode head)
        {
            if (head != null && head.next != null)
            {
                if (head.val == head.next.val)
                {
                    var headValue = head.val;
                    while (head != null && head.val == headValue)
                    {
                        head = head.next;
                    }
                    return Solution(head);
                }
                else
                {
                    head.next = Solution(head.next);
                }
            }
            return head;
        }

        public ListNode Solution_Slow(ListNode head)
        {
            if (head != null && head.next != null)
            {
                var leader = new ListNode(head.val - 1);
                leader.next = head;
                var current = leader;
                while (current != null)
                {
                    if (current.next != null && current.next.next != null && current.next.val == current.next.next.val)
                    {
                        var nextValue = current.next.val;
                        var temp = current.next.next;
                        while (temp != null && temp.val == nextValue)
                        {
                            temp = temp.next;
                        }
                        current.next = temp;
                    }
                    else
                    {
                        current = current.next;
                    }
                }
                head = leader.next;
            }
            return head;
        }
    }
}
