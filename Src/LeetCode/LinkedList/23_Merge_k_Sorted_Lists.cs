using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class MergekSortedLists
    {
        public ListNode Sollution(ListNode[] lists)
        {
            var head = default(ListNode);
            if (lists != null && lists.Length > 0)
            {
                var minHead = lists[0];
                var currentIndex = 0;
                for (int i = 0; i < lists.Length; i++)
                {
                    if (minHead == null || (lists[i] != null && lists[i].val < minHead.val))
                    {
                        minHead = lists[i];
                        currentIndex = i;
                    }
                }
                head = minHead;
                if (head != null)
                {
                    lists[currentIndex] = lists[currentIndex].next;
                    var tail = head;
                    while (minHead != null)
                    {
                        currentIndex = 0;
                        minHead = lists[0];
                        for (int i = 0; i < lists.Length; i++)
                        {
                            if (minHead == null || (lists[i] != null && lists[i].val < minHead.val))
                            {
                                minHead = lists[i];
                                currentIndex = i;
                            }
                        }
                        tail.next = minHead;
                        tail = tail.next;
                        if (minHead != null)
                            lists[currentIndex] = lists[currentIndex].next;
                    }
                }
            }
            return head;
        }

        public ListNode Sollution_Fast(ListNode[] lists)
        {
            var head = default(ListNode);
            if (lists != null && lists.Length > 0)
            {
                head = lists[0];
                for (int i = 1; i < lists.Length; i++)
                {
                    head = MergeTwo(head, lists[i]);
                }
            }
            return head;
        }

        private ListNode MergeTwo(ListNode first, ListNode second)
        {
            if (first != null && second != null)
            {
                var head = first;
                if (second.val < first.val)
                {
                    head = second;
                    second = second.next;
                }
                else
                {
                    first = first.next;
                }
                var tail = head;
                while (first != null && second != null)
                {
                    if (first.val < second.val)
                    {
                        tail.next = first;
                        first = first.next;
                    }
                    else
                    {
                        tail.next = second;
                        second = second.next;
                    }
                    tail = tail.next;
                }
                if (first != null)
                    tail.next = first;
                else if (second != null)
                    tail.next = second;
                return head;
            }
            return first ?? second;
        }

    }
}
