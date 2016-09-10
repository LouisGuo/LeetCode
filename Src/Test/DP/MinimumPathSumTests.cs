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
    public class MinimumPathSumTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var tool = new MinimumPathSum();
            var sample = new int[,] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 9, 7, 6, 5 } };
            var result = tool.Solution(sample);
        }
    }
}