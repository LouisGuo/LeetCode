using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class KthSmallestElementinaSortedMatrix
    {
        public int Solution(int[,] matrix, int k)
        {
            int h = matrix.GetLength(0);
            List<int> list = new List<int>();
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                    list.Add(matrix[i, j]);
            }
            list.Sort();
            return list[k - 1];
        }
    }
}
