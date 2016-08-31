using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Sqrtx
    {
        public int Solution(int x)
        {
            return (int)Math.Sqrt(x);
        }

        public int Solution_Real(int x)
        {
            if (x > 0)
            {
                var left = 1;
                var right = x;
                var middle = left + (right - left) / 2;
                if (middle > 46340)
                {
                    right = 46341;
                    middle = left + (right - left) / 2;
                }
                while (left < right - 1)
                {
                    var current = middle * middle;
                    if (current == x)
                        return middle;
                    else if (current > x)
                    {
                        right = middle;
                    }
                    else
                    {
                        left = middle;
                    }
                    middle = left + (right - left) / 2;
                }
                return left;
            }
            return 0;
        }
    }
}
