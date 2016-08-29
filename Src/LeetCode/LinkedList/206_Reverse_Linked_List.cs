using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseLinkedList
    {
        public ListNode Solution(ListNode head)
        {
            if (head != null)
            {
                var rest = head.next;
                head.next = null;
                while (rest != null)
                {
                    var temp = rest.next;
                    rest.next = head;
                    head = rest;
                    rest = temp;
                }
            }
            return head;
        }
        
    }
}
