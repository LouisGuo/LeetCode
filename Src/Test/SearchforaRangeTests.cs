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
    public class SearchforaRangeTests
    {
        [TestMethod()]
        public void Solution_FastTest()
        {
            var tool = new SearchforaRange();
            var result = tool.Solution_Fast(new int[] {5,7,7,8,8,10},8);
        }

        [TestMethod()]
        public void SolutionTest()
        {
            var tool = new SearchforaRange();
            var result = tool.Solution(new int[] { 1,2,3 }, 2);
        }
    }
}