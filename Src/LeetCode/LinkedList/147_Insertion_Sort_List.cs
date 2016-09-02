using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class InsertionSortList
    {
        public ListNode Solution(ListNode head)
        {
            if (head != null && head.next != null)
            {
                var current = head.next;
                head.next = null;
                while (current != null)
                {
                    var temp = current.next;
                    if (current.val < head.val)
                    {
                        current.next = head;
                        head = current;
                    }
                    else
                    {
                        var currentTemp = head.next;
                        var pre = head;
                        while (currentTemp != null && currentTemp.val < current.val)
                        {
                            pre = currentTemp;
                            currentTemp = currentTemp.next;
                        }
                        pre.next = current;
                        current.next = currentTemp;
                    }
                    current = temp;
                }
            }
            return head;
        }
    }
}
