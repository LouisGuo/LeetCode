using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Data;
using System.Collections;

namespace LeetCode.Tests
{
    [TestClass]
    public class CommonTest
    {
        public class Problem
        {
            public Problem()
            {
                this.Solutions = new List<string>();
            }

            public string Title { get; set; }

            public int ProblemNum { get; set; }

            public List<String> Solutions { get; set; }
        }

        [TestMethod]
        public void GetAllProblemsSolved()
        {
            var result = new List<Problem>();
            var directory = Directory.GetCurrentDirectory();
            for (int i = 0; i < 3; i++)
            {
                directory = Directory.GetParent(directory).FullName;
            }
            directory = Path.Combine(directory, "LeetCode");
            var files = Directory.GetFiles(directory).Select(p => p.Split('\\').Last());
            foreach (var file in files.Where(f => f.EndsWith("cs") && f.Contains("_")))
            {
                var problemNum = 0;
                if (int.TryParse(file.Split('_')[0], out problemNum))
                {
                    var problem = new Problem();
                    problem.Title = file;
                    problem.ProblemNum = problemNum;
                    result.Add(problem);
                }
            }
            result = result.OrderBy(p => p.ProblemNum).ToList();
            var table = new DataTable("Problems");
            table.Columns.Add(new DataColumn("Number", typeof(int)));
            table.Columns.Add(new DataColumn("Title", typeof(string)));
            foreach (var p in result)
            {
                var row = table.NewRow();
                row["Number"] = p.ProblemNum;
                row["Title"] = p.Title;
                table.Rows.Add(row);
            }
        }

        [TestMethod]
        public void LargeArrayTests()
        {
            GC.Collect();
            var total = GC.GetTotalMemory(false);
            //var bitArray = new BitArray(int.MaxValue);
            doSTH();
            var total1 = GC.GetTotalMemory(false);
            var increase = (total1 - total) / 1024;

            //var middle = bitArray[int.MaxValue / 2];

            var list = new List<bool>(int.MaxValue);

            var array = new bool[int.MaxValue];

            var middle1 = array[int.MaxValue / 2];
        }

        private void doSTH()
        {
            var bitArray = new BitArray(int.MaxValue);
        }

        [TestMethod]
        public void SpeedTest()
        {
            var time = StopWatchExtension.Timing(() =>
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    var resu = i & 1;
                }
            });
            var time1 = StopWatchExtension.Timing(() =>
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    var resu = i % 2;
                }
            });
        }
    }
}
