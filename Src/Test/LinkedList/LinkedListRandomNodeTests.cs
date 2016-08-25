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
    public class LinkedListRandomNodeTests
    {
        [TestMethod()]
        public void SollutionTest()
        {
            var head = new ListNode(1);
            var current = head;
            for (int i = 2; i <= 100; i++)
            {
                current.next = new ListNode(i);
                current = current.next;
            }
            var tool = new LinkedListRandomNode(head);
            var results = new List<int>();
            for (int i = 0; i < 100000; i++)
            {
                results.Add(tool.Sollution().val);
                System.Threading.Thread.Sleep(123);
            }
            var re = results.GroupBy(t => t)
                .Select(i => new KeyValuePair<int, int>(i.Key, i.Count()))
                .OrderBy(i => i.Key).ToList();

        }
    }
}