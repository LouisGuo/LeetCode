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
    public class PascalsTriangleIITests
    {
        [TestMethod()]
        public void SollutionTest()
        {
            var tool = new PascalsTriangleII();
            var result = tool.Sollution(12);
        }

        [TestMethod()]
        public void Sollution_FastTest()
        {
            var tool = new PascalsTriangleII();
            var result = tool.Sollution_Fast(12);
        }
    }
}