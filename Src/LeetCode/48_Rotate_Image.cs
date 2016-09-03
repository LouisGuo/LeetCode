using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RotateImage
    {
        public void Rotate(int[,] matrix)
        {
            var length = matrix.GetLength(0);
            var copy = new int[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    copy[i, j] = matrix[i, j];
                }
            }
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    matrix[j, length - i - 1] = copy[i, j];
                }
            }
        }
    }
}
