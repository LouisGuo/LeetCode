using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PlusOne
    {
        public int[] Solution(int[] digits)
        {
            if (digits != null && digits.Length > 0)
            {
                var result = new int[digits.Length];
                var lastIncrease = 1;
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    var sum = digits[i];
                    if (lastIncrease > 0)
                    {
                        sum += lastIncrease;
                        lastIncrease = sum / 10;
                        sum %= 10;
                    }
                    result[i] = sum;
                }
                if (lastIncrease > 0)
                {
                    result = new int[digits.Length + 1];
                    result[0] = 1;
                }
                return result;
            }
            return null;
        }
    }
}
