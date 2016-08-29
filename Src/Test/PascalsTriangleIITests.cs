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
    public class PascalsTriangleIITests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var tool = new PascalsTriangleII();
            var result = tool.Solution(12);
        }

        [TestMethod()]
        public void Solution_FastTest()
        {
            var tool = new PascalsTriangleII();
            var result = tool.Solution_Fast(12);
        }

        [TestMethod()]
        public void Solution_Memory()
        {
            var tool = new PascalsTriangleII();
            var increase = GCExtension.MemoryIncrease(()=> { tool.Solution(20); });
            var increase1 = GCExtension.MemoryIncrease(() => { tool.Solution_Fast(20); });
        }
    }
}