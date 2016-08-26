using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCode.Tests
{
    [TestClass]
    public class Reverse_String_Test
    {
        [TestMethod]
        public void Sollution_Test()
        {
            var tool = new ReverseString();
            var result = tool.Sollution("hello");
            Assert.AreEqual(result, "olleh");
        }
    }
}
