using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PascalsTriangleII
    {
        public IList<int> Sollution(int rowIndex)
        {
            var result = new List<int>();
            var last = new List<int>();
            if (rowIndex >= 0)
            {
                result = new List<int>() { 1 };
                last = new List<int>() { 1 };
                for (int i = 1; i <= rowIndex; i++)
                {
                    var row = new List<int>();
                    for (int j = 0; j <= i; j++)
                    {
                        var index = j - 1;
                        var temp = 0;
                        if (index > -1)
                            temp += last[index];
                        if (j < i)
                            temp += last[j];
                        row.Add(temp);
                    }
                    last = row;
                    result = row;
                }
            }
            return result;
        }

        public IList<int> Sollution_Fast(int rowIndex)
        {
            var result = new int[rowIndex + 1];
            if (rowIndex >= 0)
            {
                result[0] = 1;
                for (int i = 1; i <= rowIndex; i++)
                {
                    result[i] = 1;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        result[j] = result[j] + (j == 0 ? 0 : result[j - 1]);
                    }
                }
            }
            return result;
        }
    }
}
