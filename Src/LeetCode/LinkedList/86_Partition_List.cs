using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class PartitionList
    {
        public ListNode Solution(ListNode head, int x)
        {
            if (head == null || head.next == null)
                return head;
            var left = default(ListNode);
            var right = default(ListNode);
            var leftTail = default(ListNode);
            var rightTail = default(ListNode);
            while (head != null)
            {
                if (head.val < x)
                {
                    if (left == null)
                    {
                        left = head;
                        leftTail = head;
                    }
                    else
                    {
                        leftTail.next = head;
                        leftTail = leftTail.next;
                    }
                }
                else
                {
                    if (right == null)
                    {
                        right = head;
                        rightTail = head;
                    }
                    else
                    {
                        rightTail.next = head;
                        rightTail = rightTail.next;
                    }
                }
                head = head.next;
            }
            if (left == null)
                left = right;
            else
                leftTail.next = right;
            if (right != null)
                rightTail.next = null;
            return left;
        }
    }
}
