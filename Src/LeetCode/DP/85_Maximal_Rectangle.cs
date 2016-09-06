using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MaximalRectangle
    {
        public int Solution(char[,] matrix)
        {
            var result = 0;
            var x = matrix.GetLength(0);
            var y = matrix.GetLength(1);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    var startX = i;
                    var startY = j;
                    for (int tempX = startX; tempX < x; tempX++)
                    {
                        for (int tempY = startY; tempY < y; tempY++)
                        {
                            var currentCount = (tempX - startX + 1) * (tempY - startY + 1);
                            if (currentCount > result && IsValid(matrix, startX, startY, tempX, tempY))
                                result = currentCount;
                        }
                    }
                }
            }
            return result;
        }

        public int Solution_Fast(char[,] matrix)
        {
            var result = 0;
            var x = matrix.GetLength(0);
            var y = matrix.GetLength(1);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    var startX = i;
                    var startY = j;
                    var maxX = x;
                    var maxY = y;
                    for (int tempX = startX; tempX < maxX; tempX++)
                    {
                        for (int tempY = startY; tempY < maxY; tempY++)
                        {
                            var currentCount = (tempX - startX + 1) * (tempY - startY + 1);
                            if (currentCount > result)
                            {
                                if (IsValid(matrix, startX, startY, tempX, tempY))
                                {
                                    result = currentCount;
                                }
                                else
                                {
                                    maxY = tempY;
                                }
                            }

                        }
                    }
                }
            }
            return result;
        }

        private bool IsValid(char[,] matrix, int startX, int startY, int endX, int endY)
        {
            for (int i = startX; i <= endX; i++)
            {
                for (int j = startY; j <= endY; j++)
                {
                    if (matrix[i, j] == '0')
                        return false;
                }
            }
            return true;
        }
    }
}
