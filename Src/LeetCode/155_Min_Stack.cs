using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MinStack
    {
        private ListNode head;
        private ListNode innerHead;

        public MinStack()
        {

        }

        public void push(int x)
        {
            if (head == null)
            {
                head = new ListNode(x);
                innerHead = head;
            }
            else
            {
                var newNode = new ListNode(x);
                newNode.next = head;
                head = newNode;
                if (x <= innerHead.val)
                {
                    newNode.internalNext = innerHead;
                    innerHead = newNode;
                }
                else
                {
                    var current = innerHead.internalNext;
                    var prev = innerHead;
                    while (current != null && current.val < x)
                    {
                        prev = current;
                        current = current.internalNext;
                    }
                    newNode.internalNext = current;
                    prev.internalNext = newNode;
                }
            }
        }

        public void pop()
        {
            var temp = head;
            if (head != null)
            {
                head = head.next;
                temp.next = null;
                if (temp == innerHead)
                {
                    var tempInner = innerHead;
                    innerHead = innerHead.internalNext;
                    tempInner.internalNext = null;
                }
                else
                {
                    var current = innerHead;
                    var pre = innerHead;
                    while (current != temp)
                    {
                        pre = current;
                        current = current.internalNext;
                    }
                    pre.internalNext = current.internalNext;
                    current.internalNext = null;
                }
            }
        }

        public int top()
        {
            if (head != null)
            {
                return head.val;
            }
            else
            {
                throw new Exception();
            }
        }

        public int getMin()
        {
            if (innerHead != null)
            {
                return innerHead.val;
            }
            else
            {
                throw new Exception();
            }
        }

        internal class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode internalNext;
            public ListNode(int x)
            {
                val = x;
            }
        }
    }
}
