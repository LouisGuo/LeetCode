using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeTwoSortedLists
    {
        public ListNode Solution(ListNode l1, ListNode l2)
        {
            if (l1 != null && l2 != null)
            {
                var head = l1;
                if (l2.val < l1.val)
                {
                    head = l2;
                    l2 = l2.next;
                }
                else
                {
                    l1 = l1.next;
                }
                var tail = head;
                while (l1 != null && l2 != null)
                {
                    if (l1.val < l2.val)
                    {
                        tail.next = l1;
                        l1 = l1.next;
                    }
                    else
                    {
                        tail.next = l2;
                        l2 = l2.next;
                    }
                    tail = tail.next;
                }
                if (l1 != null)
                    tail.next = l1;
                else if (l2 != null)
                    tail.next = l2;
                return head;
            }
            return l1 ?? l2;
        }
    }
}
