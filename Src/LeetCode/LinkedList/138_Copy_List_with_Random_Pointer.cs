using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CopyListwithRandomPointer
    {
        public RandomListNode Solution(RandomListNode head)
        {
            var newHead = default(RandomListNode);
            if (head != null)
            {
                newHead = new RandomListNode(head.label);
                var current = head.next;
                var newCurrent = newHead;
                while (current != null)
                {
                    newCurrent.next = new RandomListNode(current.label);
                    current = current.next;
                    newCurrent = newCurrent.next;
                }
                current = head;
                newCurrent = newHead;
                while (current != null)
                {
                    var randomNext = current.random;
                    if (randomNext != null)
                    {
                        var cursor = head;
                        var newCursor = newHead;
                        while (cursor != null && randomNext != cursor)
                        {
                            cursor = cursor.next;
                            newCursor = newCursor.next;
                        }
                        newCurrent.random = newCursor;
                    }
                    current = current.next;
                    newCurrent = newCurrent.next;
                }
            }
            return newHead;
        }

        private Dictionary<RandomListNode, RandomListNode> dic = new Dictionary<RandomListNode, RandomListNode>();

        public RandomListNode Solution_Fast(RandomListNode head)
        {
            var newHead = default(RandomListNode);
            if (head != null)
            {
                if (dic.ContainsKey(head))
                    return dic[head];
                newHead = new RandomListNode(head.label);
                dic[head] = newHead;
                newHead.next = Solution_Fast(head.next);
                newHead.random = Solution_Fast(head.random);
            }
            return newHead;
        }










        public class RandomListNode
        {
            public int label;

            public RandomListNode next, random;

            public RandomListNode(int x) { this.label = x; }
        }
    }
}
