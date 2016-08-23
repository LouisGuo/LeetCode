using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Data;

namespace Test
{
    [TestClass]
    public class CommonTest
    {
        public class Problem
        {
            public Problem()
            {
                this.Sollutions = new List<string>();
            }

            public string Title { get; set; }

            public int ProblemNum { get; set; }

            public List<String> Sollutions { get; set; }
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
    }
}
