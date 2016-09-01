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
    public class SuperPowTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var tool = new SuperPow();
            var result = tool.Solution(int.MaxValue, new int[] { 2,0,0});
        }
    }
}