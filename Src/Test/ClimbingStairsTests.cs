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
    public class ClimbingStairsTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var n = 45;
            var tool = new ClimbingStairs();
            var time = StopWatchExtension.Timing(() => { tool.Solution(n); });
            var time1 = StopWatchExtension.Timing(() => { tool.Solution_Fast(n); });
            var time2 = StopWatchExtension.Timing(() => { tool.Solution_Faster(n); });
        }
    }
}