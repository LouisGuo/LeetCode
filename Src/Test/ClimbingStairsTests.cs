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
        public void SollutionTest()
        {
            var n = 45;
            var tool = new ClimbingStairs();
            var time = StopWatchExtension.Timing(() => { tool.Sollution(n); });
            var time1 = StopWatchExtension.Timing(() => { tool.Sollution_Fast(n); });
            var time2 = StopWatchExtension.Timing(() => { tool.Sollution_Faster(n); });
        }
    }
}