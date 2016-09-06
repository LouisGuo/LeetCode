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
    public class InsertIntervalTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var tool = new InsertInterval();
            var sample = new List<InsertInterval.Interval>()
            {
                new InsertInterval.Interval(1,5)
            };
            var result = tool.Solution(sample, new InsertInterval.Interval(1, 7));
        }
    }
}