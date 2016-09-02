using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SortList
    {
        public ListNode Solution_QuickSort(ListNode head)
        {
            if (head != null && head.next != null)
            {
                var middleHead = default(ListNode);
                var leftHead = head;
                var rightHead = default(ListNode);
                var current = head.next;
                head.next = null;
                while (current != null)
                {
                    var temp = current.next;
                    if (current.val < head.val)
                    {
                        current.next = leftHead;
                        leftHead = current;
                    }
                    else if (current.val > head.val)
                    {
                        current.next = rightHead;
                        rightHead = current;
                    }
                    else
                    {
                        current.next = middleHead;
                        middleHead = current;
                    }
                    current = temp;
                }
                leftHead = Solution_QuickSort(leftHead);
                rightHead = Solution_QuickSort(rightHead);
                if (middleHead != null)
                {
                    head.next = middleHead;
                    head = middleHead;
                    while (head.next != null)
                    {
                        head = head.next;
                    }
                }
                head.next = rightHead;
                head = leftHead;
            }
            return head;
        }
    }
}
