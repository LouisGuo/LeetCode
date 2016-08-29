using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PalindromeLinkedList
    {
        public bool Solution(ListNode head)
        {
            var slow = head;
            var fast = head;
            var stack = new Stack<int>();
            while (fast != null && fast.next != null)
            {
                stack.Push(slow.val);
                slow = slow.next;
                fast = fast.next.next;
            }
            if (fast != null)
                stack.Push(slow.val);
            while (slow != null)
            {
                if (slow.val != stack.Pop())
                    return false;
                slow = slow.next;
            }
            return true;
        }
    }
}
