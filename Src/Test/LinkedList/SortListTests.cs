﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class SortListTests
    {
        [TestMethod()]
        public void Solution_QuickSortTest()
        {
            var tool = new SortList();
            var sample = new ListNode(1);
            sample.next = new ListNode(2);
            sample.next.next = new ListNode(5);
            sample.next.next.next = new ListNode(4);
            sample.next.next.next.next = new ListNode(5);
            //sample.next.next.next.next.next = new ListNode(6);
            //sample.next.next.next.next.next.next = new ListNode(7);
            var result = tool.Solution_QuickSort(sample);
        }
    }
}