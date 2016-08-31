using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Powxn
    {
        public double Solution(double x, int n)
        {
            var result = 1d;
            if (n == 0)
                return 1;
            else if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    result *= x;
                }
            }
            else
            {
                for (int i = 0; i < (-1) * n; i++)
                {
                    result *= x;
                }
                result = 1d / result;
            }
            return result;
        }

        public double Solution_Fast(double x, int n)
        {
            var result = 1d;
            var isNegtive = n < 0;
            if (n == 0)
                return 1;
            else if (n == int.MinValue)
            {
                if (x == 0 || x == 1)
                    return x;
                if (x == -1)
                    return 1;
                else if (x > 1 || x < -1)
                    return 0;
                else
                {
                    return double.PositiveInfinity;
                }
            }
            else
            {
                if (isNegtive)
                    n *= -1;
                if (n >= 10)
                {
                    var middle = n / 2;
                    var middleValue = Solution_Fast(x, middle);
                    result = middleValue * middleValue;
                    if (2 * middle < n)
                        result *= x;
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        result *= x;
                    }
                }
            }
            if (isNegtive)
                result = 1 / result;
            return result;
        }
    }
}
