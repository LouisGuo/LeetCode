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
    public class MergeIntervalsTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var tool = new MergeIntervals();
            var sample = new List<MergeIntervals.Interval>()
            {
                 new MergeIntervals.Interval(2,3),new MergeIntervals.Interval(4,5),new MergeIntervals.Interval(6,7),new MergeIntervals.Interval(8,9),new MergeIntervals.Interval(1,10),
            };
            var result = tool.Solution(sample);
        }
    }
}