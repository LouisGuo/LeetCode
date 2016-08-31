using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidPerfectSquare
    {
        public bool Solution_Real(int num)
        {
            if (num > 0)
            {
                var left = 1;
                var right = num;
                var middle = left + (right - left) / 2;
                if (middle > 46340)
                {
                    right = 46341;
                    middle = left + (right - left) / 2;
                }
                while (left < right - 1)
                {
                    var current = middle * middle;
                    if (current == num)
                        return true;
                    else if (current > num)
                    {
                        right = middle;
                    }
                    else
                    {
                        left = middle;
                    }
                    middle = left + (right - left) / 2;
                }
                return left * left == num;
            }
            return false;
        }
    }
}
