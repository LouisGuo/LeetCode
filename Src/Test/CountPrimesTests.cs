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
        public void Sollution_FastTest()
        {
            var tool = new CountPrimes();
            //var time = StopWatchExtension.Timing(() => { tool.Sollution(200000); });
            //var time1 = StopWatchExtension.Timing(() => { tool.Sollution_Fast(200000); });
            var time2 = StopWatchExtension.Timing(() => { tool.Sollution_Faster(int.MaxValue); });
        }
    }
}