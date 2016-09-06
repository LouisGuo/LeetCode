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
    public class UTF8ValidationTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var tool = new UTF8Validation();
            var result = tool.Solution(new int[] { 39, 89, 227, 83, 132, 95, 10, 0 });
        }
    }
}