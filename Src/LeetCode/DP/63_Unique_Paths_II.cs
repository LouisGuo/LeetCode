using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class UniquePathsII
    {
        public int Solution(int[,] obstacleGrid)
        {
            var result = 0;
            if (obstacleGrid != null)
            {
                var row = obstacleGrid.GetLength(0);
                var colum = obstacleGrid.GetLength(1);
                var sums = new int[row, colum];
                sums[0, 0] = 1;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < colum; j++)
                    {
                        if (obstacleGrid[i, j] == 1)
                            sums[i, j] = 0;
                        else
                        {
                            if (i > 0)
                                sums[i, j] += sums[i - 1, j];
                            if (j > 0)
                                sums[i, j] += sums[i, j - 1];
                        }
                    }
                }
                result = sums[row - 1, colum - 1];
            }
            return result;
        }
    }
}
