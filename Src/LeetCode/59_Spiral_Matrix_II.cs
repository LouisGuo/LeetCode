using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SpiralMatrixII
    {
        public int[,] Solution(int n)
        {
            var length = Math.Sqrt(n);
            var result = new int[n, n];
            if (n > 1)
                GenerateN(result, 1, 0, 0, n - 1, n - 1);
            else if (n == 1)
                result[0, 0] = 1;
            return result;
        }

        private void GenerateN(int[,] matrix, int count,
            int startX, int startY, int endX, int endY)
        {
            for (int i = startY; i <= endY; i++)
            {
                matrix[startX, i] = count++;
            }
            for (int i = startX + 1; i < endX; i++)
            {
                matrix[i, endY] = count++;
            }
            for (int i = endY; startX != endX && i >= startY; i--)
            {
                matrix[endX, i] = count++;
            }
            for (int i = endX - 1; startY != endY && i > startX; i--)
            {
                matrix[i, startY] = count++;
            }
            ++startX; ++startY; --endX; --endY;
            if (startX <= endX && startY <= endY)
                GenerateN(matrix, count, startX, startY, endX, endY);
        }
    }
}
