using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class PalindromeLinkedListTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var tool = new PalindromeLinkedList();
            var sample = new ListNode(1);
            sample.next = new ListNode(2);
            sample.next.next = new ListNode(3);
            sample.next.next.next = new ListNode(3);
            sample.next.next.next.next = new ListNode(2);
            sample.next.next.next.next.next = new ListNode(1);
            var result = tool.Solution(sample);
        }
    }
}