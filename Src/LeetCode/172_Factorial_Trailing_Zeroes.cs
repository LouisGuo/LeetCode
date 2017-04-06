using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FactorialTrailingZeroes
    {
        public int Solution(int n)
        {
            if (n < 0)
                return -1;
            var result = 0;
            while (n > 0)
            {
                result += (n / 5);
                n /= 5;
            }
            return result;
        }
    }
}
