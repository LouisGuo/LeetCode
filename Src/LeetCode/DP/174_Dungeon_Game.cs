using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class DungeonGame
    {
        public int Solution(int[,] dungeon)
        {
            var result = 0;
            if (dungeon != null)
            {
                var row = dungeon.GetLength(0);
                var colum = dungeon.GetLength(1);
                var max = new int[row, colum];
                var min = new int[row, colum];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < colum; j++)
                    {
                        if (i == 0 && j == 0)
                        {
                            max[0, 0] = dungeon[0, 0];
                            min[0, 0] = dungeon[0, 0];
                        }
                        else if (i == 0)
                        {
                            max[i, j] = max[i, j - 1] + dungeon[i, j];
                            min[i, j] = Math.Min(min[i, j - 1], max[i, j]);
                        }
                        else if (j == 0)
                        {
                            max[i, j] = max[i - 1, j] + dungeon[i, j];
                            min[i, j] = Math.Min(min[i - 1, j], max[i, j]);
                        }
                        else
                        {
                            if (max[i - 1, j] > max[i, j - 1])
                            {
                                max[i, j] = max[i - 1, j] + dungeon[i, j];
                                min[i, j] = Math.Min(min[i - 1, j], max[i, j]);
                            }
                            else if (max[i - 1, j] < max[i, j - 1])
                            {
                                max[i, j] = max[i, j - 1] + dungeon[i, j];
                                min[i, j] = Math.Min(min[i, j - 1], max[i, j]);
                            }
                            else
                            {

                            }
                            max[i, j] = Math.Max(max[i - 1, j], max[i, j - 1]) + dungeon[i, j];
                        }
                    }
                }
                result = max[row - 1, colum - 1];
                if (result >= 0)
                    result = 1;
                else
                    result = -1 * result + 1;
            }
            return result;
        }
    }
}
