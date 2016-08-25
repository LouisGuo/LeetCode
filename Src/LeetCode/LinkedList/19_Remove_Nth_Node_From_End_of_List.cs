using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveNthNodeFromEndofList
    {
        public ListNode Sollution(ListNode head, int n)
        {
            var current = head;
            var count = 0;
            while (current != null)
            {
                current = current.next;
                count++;
            }
            if (n > 0 && n <= count)
            {
                current = head;
                if (n == count)
                {
                    head = head.next;
                    current.next = null;
                }
                else
                {
                    var prev = current;
                    for (int i = 0; i < count - n; i++)
                    {
                        prev = current;
                        current = current.next;
                    }
                    prev.next = current.next;
                    current.next = null;
                }
            }
            return head;
        }

        public ListNode Sollution_Fast(ListNode head, int n)
        {
            var current = head;
            var temp = head;
            for (int i = 1; i < n; i++)
            {
                current = current.next;
            }
            if (current.next == null)
            {
                head = head.next;
                temp.next = null;
            }
            else
            {
                var prev = temp;
                while (current.next != null)
                {
                    prev = temp;
                    temp = temp.next;
                    current = current.next;
                }
                prev.next = prev.next.next;
                temp.next = null;
            }
            return head;
        }
        
    }
}
