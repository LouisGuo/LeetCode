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
    public class ReverseIntegerTests
    {
        [TestMethod()]
        public void SollutionTest()
        {
            var tool = new ReverseInteger();
            var result = tool.Sollution(-2147483648);
        }
    }
}