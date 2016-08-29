using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PalindromeNumber
    {
        public bool Solution(int x)
        {
            if (x < 0)
                return false;
            else
            {
                var xStr = x.ToString();
                var left = 0;
                var right = xStr.Length - 1;
                while (left < right)
                {
                    if (xStr[left++] != xStr[right--])
                        return false;
                }
                return true;
            }
        }
    }
}
