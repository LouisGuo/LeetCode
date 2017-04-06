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
    public class CombinationSumIITests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var tool = new CombinationSumII();
            var result = tool.Solution(new int[] { 10, 1, 2, 7, 6, 1, 5 },8);
        }
    }
}