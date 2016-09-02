using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IntersectionofTwoLinkedLists
    {
        public ListNode Solution(ListNode headA, ListNode headB)
        {
            var currentA = headA;
            var currentB = headB;
            while (currentA != currentB)
            {
                currentA = currentA == null ? headB : currentA.next;
                currentB = currentB == null ? headA : currentB.next;
            }
            return currentA;
        }

        public ListNode Solution_Slow(ListNode headA, ListNode headB)
        {
            if (headA != null && headB != null)
            {
                var currentA = headA;
                var currentB = headB;
                var countA = 0;
                var countB = 0;
                while (currentA != null)
                {
                    currentA = currentA.next;
                    countA++;
                }
                while (currentB != null)
                {
                    currentB = currentB.next;
                    countB++;
                }
                currentA = headA;
                currentB = headB;
                if (countA > countB)
                {
                    for (int i = 0; i < countA - countB; i++)
                    {
                        currentA = currentA.next;
                    }
                }
                else if (countA < countB)
                {
                    for (int i = 0; i < countB - countA; i++)
                    {
                        currentB = currentB.next;
                    }
                }
                while (currentB != currentA)
                {
                    currentA = currentA.next;
                    currentB = currentB.next;
                }
                return currentA;
            }
            return null;
        }
    }
}
