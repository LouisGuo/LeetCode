using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class UniquePaths
    {
        public int Solution(int m, int n)
        {
            var result = 0;
            if (m > 0 && n > 0)
            {
                var sums = new int[m, n];
                sums[0, 0] = 1;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i > 0)
                            sums[i, j] += sums[i - 1, j];
                        if (j > 0)
                            sums[i, j] += sums[i, j - 1];
                    }
                }
                result = sums[m - 1, n - 1];
            }
            return result;
        }
    }
}
