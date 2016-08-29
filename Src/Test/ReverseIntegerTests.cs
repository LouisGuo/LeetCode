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
        public void SolutionTest()
        {
            var tool = new ReverseInteger();
            var result = tool.Solution(-2147483648);
        }
    }
}