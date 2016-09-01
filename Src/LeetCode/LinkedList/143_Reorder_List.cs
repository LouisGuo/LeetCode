using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReorderList
    {
        public void Solution(ListNode head)
        {
            if (head != null && head.next != null)
            {
                var stack = new Stack<ListNode>();
                var queue = new Queue<ListNode>();
                var current = head;
                while (current != null)
                {
                    queue.Enqueue(current);
                    current = current.next;
                    if (current != null)
                    {
                        stack.Push(current);
                        current = current.next;
                    }
                }
                head.next = stack.Pop();
                current = head.next;
                while (queue.Count > 0 && stack.Count > 0)
                {
                    current.next = queue.Dequeue();
                    current = current.next;
                    current.next = stack.Pop();
                    current = current.next;
                }
                if (queue.Count > 0)
                    current.next = queue.Dequeue();
                else if (stack.Count > 0)
                    current.next = stack.Pop();
                if (current.next != null)
                    current.next.next = null;
            }
        }
    }
}
