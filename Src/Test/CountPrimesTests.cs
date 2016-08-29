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
    public class CountPrimesTests
    {
        [TestMethod()]
        public void Solution_FastTest()
        {
            var tool = new CountPrimes();
            var result = 0;
            //var time = StopWatchExtension.Timing(() => { tool.Solution(200000); });
            //var time1 = StopWatchExtension.Timing(() => { tool.Solution_Fast(200000); });
            var time2 = StopWatchExtension.Timing(() => { result = tool.Solution_FasterEvenMore(int.MaxValue); });
        }
    }
}