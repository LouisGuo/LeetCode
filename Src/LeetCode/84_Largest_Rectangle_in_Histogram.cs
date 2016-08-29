using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LargestRectangleinHistogram
    {
        public int Sollution(int[] heights)
        {
            var result = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                var min = int.MaxValue;
                for (int j = i; j < heights.Length; j++)
                {
                    if (heights[j] == 0)
                        break;
                    else if (heights[j] < min)
                        min = heights[j];
                    var current = (j - i + 1) * min;
                    if (current > result)
                        result = current;
                }
            }
            return result;
        }
    }
}
