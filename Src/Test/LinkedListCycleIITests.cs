using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static LeetCode.LinkedListCycleII;

namespace LeetCode.Tests
{
    [TestClass()]
    public class LinkedListCycleIITests
    {
        [TestMethod()]
        public void Solution_FastTest()
        {
            var listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            var node = new ListNode(4);
            listNode.next.next.next = node;
            listNode.next.next.next.next = new ListNode(5);
            listNode.next.next.next.next.next = new ListNode(6);
            listNode.next.next.next.next.next.next = new ListNode(7);
            listNode.next.next.next.next.next.next.next = new ListNode(8);
            listNode.next.next.next.next.next.next.next.next = new ListNode(9);
            listNode.next.next.next.next.next.next.next.next.next = new ListNode(10);
            listNode.next.next.next.next.next.next.next.next.next.next = new ListNode(11);
            var tail = new ListNode(12);
            listNode.next.next.next.next.next.next.next.next.next.next.next = tail;
            tail.next = node;
            var tool = new LinkedListCycleII();
            var result = tool.Solution_Fast(listNode);
        }

        [TestMethod()]
        public void Solution_FastTest1()
        {
            var listNode = new ListNode(1);
            listNode.next = listNode;
            var tool = new LinkedListCycleII();
            var result = tool.Solution_Fast(listNode);
        }

        [TestMethod()]
        public void Solution_FastTest2()
        {
            var listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            var node = new ListNode(4);
            listNode.next.next.next = node;
            listNode.next.next.next.next = new ListNode(5);
            listNode.next.next.next.next.next = new ListNode(6);
            listNode.next.next.next.next.next.next = new ListNode(7);
            listNode.next.next.next.next.next.next.next = new ListNode(8);
            listNode.next.next.next.next.next.next.next.next = new ListNode(9);
            listNode.next.next.next.next.next.next.next.next.next = new ListNode(10);
            listNode.next.next.next.next.next.next.next.next.next.next = new ListNode(11);
            var tail = new ListNode(12);
            listNode.next.next.next.next.next.next.next.next.next.next.next = tail; 
            var tool = new LinkedListCycleII();
            var result = tool.Solution_Fast(listNode);
        }
    }
}