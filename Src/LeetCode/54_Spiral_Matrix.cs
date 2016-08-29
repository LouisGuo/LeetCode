using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SpiralMatrix
    {
        public IList<int> Solution(int[,] matrix)
        {
            var result = new List<int>();
            if (matrix != null && matrix.GetLength(0) > 0 && matrix.GetLength(1) > 0)
                GenerateN(matrix, result, 0, 0, matrix.GetLength(0) - 1, matrix.GetLength(1) - 1);
            return result;
        }

        private void GenerateN(int[,] matrix, IList<int> result,
            int startX, int startY, int endX, int endY)
        {
            for (int i = startY; i <= endY; i++)
            {
                result.Add(matrix[startX, i]);
            }
            for (int i = startX + 1; i < endX; i++)
            {
                result.Add(matrix[i, endY]);
            }
            for (int i = endY; startX != endX && i >= startY; i--)
            {
                result.Add(matrix[endX, i]);
            }
            for (int i = endX - 1; startY != endY && i > startX; i--)
            {
                result.Add(matrix[i, startY]);
            }
            ++startX; ++startY; --endX; --endY;
            if (startX <= endX && startY <= endY)
                GenerateN(matrix, result, startX, startY, endX, endY);
        }
    }
}
