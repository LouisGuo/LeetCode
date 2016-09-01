using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SuperPow
    {
        public int Solution(int a, int[] b)
        {
            if (b != null && b.Length > 0 && a != 0)
            {
                var result = 1;
                var level = 1;
                for (int i = b.Length - 1; i >= 0; i--)
                {
                    var count = b[i] * level;
                    for (int j = 0; j < count; j++)
                    {
                        result *= a;
                    }
                    level *= 10;
                }
                return result;
            }
            return 0;
        }
    }
}
