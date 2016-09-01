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
                    stack.Push(current);
                    current = current.next;
                }
                head = queue.Dequeue();
                head.next = stack.Pop();
                current = head.next;
                while (queue.Count > 0)
                {
                    var queueNode = queue.Dequeue();
                    var stackNode = stack.Pop();
                    if (current.Equals(queueNode))
                        break;
                    current.next = queueNode;
                    current = current.next;
                    if (!stackNode.Equals(queueNode))
                    {
                        current.next = stackNode;
                        current = current.next;
                    }
                    else
                        break;
                }
                current.next = null;
            }
        }
    }
}
