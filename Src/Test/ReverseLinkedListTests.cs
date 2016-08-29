using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.ReverseLinkedList;

namespace LeetCode.Tests
{
    [TestClass()]
    public class ReverseLinkedListTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var tool = new ReverseLinkedList();
            var list = new ListNode(1);
            list.next = new ListNode(2);
            list.next.next = new ListNode(3);
            list.next.next.next = new ListNode(4);
            var result = tool.Solution(list);
        }
    }
}