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
    public class FirstBadVersionTests
    {
        [TestMethod()]
        public void Sollution_FastTest()
        {
            var tool = new FirstBadVersion();
            var result = tool.Sollution_Fast(2126753390);
        }
    }
}