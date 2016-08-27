using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ImplementQueueusingStacks
    {
        private Stack<int> stack = new Stack<int>();
        private Stack<int> reversedStack = new Stack<int>();

        // Push element x to the back of queue.
        public void Push(int x)
        {
            while (reversedStack.Count > 0)
            {
                stack.Push(reversedStack.Pop());
            }
            reversedStack.Push(x);
            while (stack.Count > 0)
            {
                reversedStack.Push(stack.Pop());
            }
        }

        // Removes the element from front of queue.
        public void Pop()
        {
            reversedStack.Pop();
        }

        // Get the front element.
        public int Peek()
        {
            return reversedStack.Peek();
        }

        // Return whether the queue is empty.
        public bool Empty()
        {
            return reversedStack.Count == 0;
        }
    }

    public class ImplementQueueusingStacks_Fast
    {
        private Stack<int> stack = new Stack<int>();
        private Stack<int> reversedStack = new Stack<int>();

        // Push element x to the back of queue.
        public void Push(int x)
        {
            stack.Push(x);
        }

        // Removes the element from front of queue.
        public void Pop()
        {
            if (reversedStack.Count == 0)
            {
                while (stack.Count > 0)
                {
                    reversedStack.Push(stack.Pop());
                }
            }
            reversedStack.Pop();
        }

        // Get the front element.
        public int Peek()
        {
            if (reversedStack.Count == 0)
            {
                while (stack.Count > 0)
                {
                    reversedStack.Push(stack.Pop());
                }
            }
            return reversedStack.Peek();
        }

        // Return whether the queue is empty.
        public bool Empty()
        {
            return reversedStack.Count == 0 && stack.Count == 0;
        }
    }
}
