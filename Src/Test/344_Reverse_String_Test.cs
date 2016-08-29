using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode.Tests
{
    [TestClass]
    public class Reverse_String_Test
    {
        [TestMethod]
        public void Solution_Test()
        {
            var tool = new ReverseString();
            var result = tool.Solution("hello");
            Assert.AreEqual(result, "olleh");
        }
    }
}
