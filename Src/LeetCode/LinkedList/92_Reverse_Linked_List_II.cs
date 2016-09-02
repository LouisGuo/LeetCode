using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseLinkedListII
    {
        public ListNode Solution(ListNode head, int m, int n)
        {
            if (head != null && head.next != null && n != m)
            {
                var leader = new ListNode(0);
                leader.next = head;
                var leftTail = leader;
                var reversedHead = leader;
                var reversedTail = leader;
                var current = leader;
                for (int i = 0; i < m - 1; i++)
                {
                    current = current.next;
                }
                leftTail = current;
                current = current.next;
                reversedTail = current;
                reversedHead = current;
                for (int i = m; i < n+1; i++)
                {
                    var temp = current;
                    current = current.next;
                    temp.next = reversedHead;
                    reversedHead = temp;
                }
                leftTail.next = reversedHead;
                reversedTail.next = current;
                head = leader.next;
            }
            return head;
        }
    }
}
