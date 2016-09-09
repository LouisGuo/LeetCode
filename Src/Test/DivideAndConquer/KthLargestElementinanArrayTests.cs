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
    public class KthLargestElementinanArrayTests
    {
        [TestMethod()]
        public void Solution_RealTest()
        {
            var tool = new KthLargestElementinanArray();
            var result = tool.Solution_Real(new int[] { 1, 2, 3, 4, 5, 9, 8 }, 1);
        }
    }
}