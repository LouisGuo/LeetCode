﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveDuplicatesfromSortedList
    {
        public ListNode Solution(ListNode head)
        {
            var current = head;
            while (current != null && current.next != null)
            {
                if (current.val.Equals(current.next.val))
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
            return head;
        }
         
    }


}
