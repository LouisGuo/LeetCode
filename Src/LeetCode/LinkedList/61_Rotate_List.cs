using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RotateList
    {
        public ListNode Solution(ListNode head, int k)
        {
            if (head != null && head.next != null && k > 0)
            {
                var count = 1;
                var tail = head;
                while (tail.next != null)
                {
                    tail = tail.next;
                    count++;
                }
                tail.next = head;
                if (k >= count)
                    k = k % count;
                for (int i = 1; i < count - k; i++)
                {
                    head = head.next;
                }
                tail = head;
                head = head.next;
                tail.next = null;
            }
            return head;
        }
        
    }
}
