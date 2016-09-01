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
    public class ReorderListTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var tool = new ReorderList();
            var sample = new ListNode(1);
            sample.next = new ListNode(2);
            sample.next.next = new ListNode(3);
            sample.next.next.next = new ListNode(4); 
             tool.Solution(sample);
        }
    }
}