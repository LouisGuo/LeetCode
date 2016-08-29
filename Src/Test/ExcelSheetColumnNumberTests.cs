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
    public class ExcelSheetColumnNumberTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var tool = new ExcelSheetColumnNumber();
            var result = tool.Solution("AAA");
            Assert.AreEqual(11,result);
        }
    }
}