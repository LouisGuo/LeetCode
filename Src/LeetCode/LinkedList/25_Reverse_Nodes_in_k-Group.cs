using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseNodesinkGroup
    {
        public ListNode Solution(ListNode head, int k)
        {
            if (head == null || head.next == null || k < 2)
            {
                return head;
            }
            var rest = head;
            var tail = head;
            while (rest != null)
            {
                int cursor = 0;
                var currentStart = rest;
                for (cursor = 0; cursor < k && rest != null; cursor++)
                {
                    rest = rest.next;
                }
                if (cursor == k)
                {
                    var restTemp = currentStart.next;
                    var headTemp = currentStart;
                    while (rest != restTemp)
                    {
                        var temp = restTemp.next;
                        restTemp.next = headTemp;
                        headTemp = restTemp;
                        restTemp = temp;
                    }
                    if (tail == head)
                    {
                        head = headTemp;
                    }
                    else
                    {
                        tail.next = headTemp;
                    }
                    tail = currentStart;
                    tail.next = rest;
                }
                else
                {
                    if (tail != head)
                        tail.next = currentStart;
                }
            }
            return head;
        }
    }
}
