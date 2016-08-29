using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PascalsTriangle
    {
        public IList<IList<int>> Solution(int numRows)
        {
            var result = new List<IList<int>>();
            if (numRows > 0)
            {
                result.Add(new List<int>() { 1 });
                for (int i = 1; i < numRows; i++)
                {
                    var row = new List<int>();
                    for (int j = 0; j < i + 1; j++)
                    {
                        var index = j - 1;
                        var temp = 0;
                        if (index > -1)
                            temp += result[i - 1][index];
                        if (j < i)
                            temp += result[i - 1][j];
                        row.Add(temp);
                    }
                    result.Add(row);
                }
            }
            return result;
        }
    }
}
