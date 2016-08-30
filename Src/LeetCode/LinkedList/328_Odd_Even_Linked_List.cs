using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class OddEvenLinkedList
    {
        public ListNode Solution(ListNode head)
        {
            if (head != null && head.next != null)
            {
                var odd = head;
                var even = head.next;
                var oddTail = odd;
                var evenTail = even;
                var oddCurrent = odd;
                var evenCurrent = even;
                oddCurrent = evenCurrent.next;
                evenCurrent = oddCurrent == null ? null : oddCurrent.next;
                while (oddCurrent != null || evenCurrent != null)
                {
                    oddTail.next = oddCurrent;
                    evenTail.next = evenCurrent;
                    if (oddCurrent != null)
                    {
                        oddTail = oddCurrent;
                    }
                    if (evenCurrent != null)
                    {
                        evenTail = evenCurrent;
                    }
                    oddCurrent = evenCurrent == null ? null : evenCurrent.next;
                    evenCurrent = oddCurrent == null ? null : oddCurrent.next;
                }
                oddTail.next = even;
            }
            return head;
        }
    }
}
