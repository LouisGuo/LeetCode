using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ImplementStackusingQueues
    {
        private Queue<int> queue = new Queue<int>();

        // Push element x onto stack.
        public void Push(int x)
        {
            queue.Enqueue(x);
        }

        // Removes the element on top of the stack.
        public void Pop()
        {
            var newQueue = new Queue<int>();
            while (queue.Count > 1)
            {
                newQueue.Enqueue(queue.Dequeue());
            }
            queue = newQueue;
        }

        // Get the top element.
        public int Top()
        {
            var newQueue = new Queue<int>();
            while (queue.Count > 1)
            {
                newQueue.Enqueue(queue.Dequeue());
            }
            var result = queue.Dequeue();
            newQueue.Enqueue(result);
            queue = newQueue;
            return result;
        }

        // Return whether the stack is empty.
        public bool Empty()
        {
            return queue.Count == 0;
        }
    }

    public class ImplementStackusingQueues_Small
    {
        private Queue<int> queue = new Queue<int>();

        // Push element x onto stack.
        public void Push(int x)
        {
            queue.Enqueue(x);
            var count = queue.Count;
            while (count-- > 1)
            {
                queue.Enqueue(queue.Dequeue());
            }
        }

        // Removes the element on top of the stack.
        public void Pop()
        {
            queue.Dequeue();
        }

        // Get the top element.
        public int Top()
        {
            return queue.Peek();
        }

        // Return whether the stack is empty.
        public bool Empty()
        {
            return queue.Count == 0;
        }
    }
}
