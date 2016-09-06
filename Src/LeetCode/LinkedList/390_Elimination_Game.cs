using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class EliminationGame
    {
        public int Solution(int n)
        {
            var result = 1;
            if (n >= 2)
            {
                var head = new DoubleListNode(2);
                for (int i = 4; i < n + 1; i += 2)
                {
                    head.next = new DoubleListNode(i);
                    head.next.pre = head;
                    head = head.next;
                }
                while (head.next != null || head.pre != null)
                {
                    if (head.next != null)
                    {
                        head = head.next;
                        head.pre.next = null;
                        head.pre = null;
                        while (head.next != null)
                        {
                            if (head.next.next != null)
                            {
                                head.next = head.next.next;
                                head = head.next;
                                head.pre = head.pre.pre;
                            }
                            else
                            {
                                head.next = null;
                            }
                        }
                    }
                    else
                    {
                        head = head.pre;
                        head.next.pre = null;
                        head.next = null;
                        while (head.pre != null)
                        {
                            if (head.pre.pre != null)
                            {
                                head.pre = head.pre.pre;
                                head = head.pre;
                                head.next = head.next.next;
                            }
                            else
                            {
                                head.pre = null;
                            }
                        }
                    }
                }
                result = head.val;
            }
            return result;
        }

        public class DoubleListNode
        {
            public int val;

            public DoubleListNode next, pre;

            public DoubleListNode(int x) { val = x; }
        }

        public int Solution_Fast(int n)
        {
            return ToRight(n);
        }

        private int ToLeft(int n)
        {
            if (n < 3)
                return 1;
            else
            {
                if ((n & 1) == 1)
                {
                    return 2 * ToRight(n / 2);
                }
                else
                {
                    return 2 * ToRight(n / 2) - 1;
                }
            }
        }

        private int ToRight(int n)
        {
            if (n < 3)
                return n;
            else
            {
                return 2 * ToLeft(n / 2);
            }
        }

    }
}
