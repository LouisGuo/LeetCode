using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MinimumPathSum
    {
        public int Solution(int[,] grid)
        {
            var result = 0;
            if (grid != null)
            {
                var row = grid.GetLength(0);
                var colum = grid.GetLength(1);
                var min = new int[row, colum];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < colum; j++)
                    {
                        var topX = i - 1;
                        var topY = j;
                        var leftX = i;
                        var leftY = j - 1;
                        var topValue = -1;
                        var leftValue = -1;
                        if (topX >= 0)
                        {
                            topValue = min[topX, topY];
                        }
                        if (leftY >= 0)
                        {
                            leftValue = min[leftX, leftY];
                        }
                        if (topValue == -1 && leftValue == -1)
                        {
                            min[i, j] = grid[i, j];
                        }
                        else if (topValue == -1)
                        {
                            min[i, j] = leftValue + grid[i, j];
                        }
                        else if (leftValue == -1)
                        {
                            min[i, j] = topValue + grid[i, j];
                        }
                        else
                        {
                            min[i, j] = Math.Min(topValue, leftValue) + grid[i, j];
                        }
                    }
                }
                result = min[row - 1, colum - 1];
            }
            return result;
        }
    }
}
