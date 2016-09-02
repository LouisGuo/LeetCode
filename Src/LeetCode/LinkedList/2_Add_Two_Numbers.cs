using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AddTwoNumbers
    {
        public ListNode Solution(ListNode l1, ListNode l2)
        {
            var head = default(ListNode);
            if (l1 != null && l2 != null)
            {
                var lastIncrease = (l1.val + l2.val) / 10;
                head = new ListNode((l1.val + l2.val) % 10);
                var tail = head;
                l1 = l1.next;
                l2 = l2.next;
                while (l1 != null || l2 != null)
                {
                    var sum = lastIncrease;
                    if (l1 != null)
                    {
                        sum += l1.val;
                        l1 = l1.next;
                    }
                    if (l2 != null)
                    {
                        sum += l2.val;
                        l2 = l2.next;
                    }
                    lastIncrease = sum / 10;
                    tail.next = new ListNode(sum % 10);
                    tail = tail.next;
                }
                if (lastIncrease > 0)
                    tail.next = new ListNode(lastIncrease);
            }
            return head;
        }
    }
}
