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
    public class ReverseVowelsofaStringTests
    {
        [TestMethod()]
        public void Sollution_SlowerTest()
        {
            var tool = new ReverseVowelsofaString();
            var result = tool.Sollution_Slower("hello");
        }
    }
}