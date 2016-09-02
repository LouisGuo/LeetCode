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
    public class PermutationsTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var tool = new Permutations();
            var result = tool.Solution(new int[] { 1,2});
        }
    }
}