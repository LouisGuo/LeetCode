using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LinkedListRandomNode
    {
        private ListNode head;

        public LinkedListRandomNode(ListNode head)
        {
            this.head = head;
        }

        public ListNode Solution()
        {
            var result = head;
            var current = head.next;
            var count = 1;
            var random = new Random();
            while (current != null)
            {
                if (random.Next(++count) == 0)
                {
                    result = current;
                }
                current = current.next;
            }
            return result;
        }
    }
}
