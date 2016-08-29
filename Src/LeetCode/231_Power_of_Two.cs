using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PowerofTwo
    {
        public bool Solution(int n)
        {
            if (n <= 0)
                return false;
            return n == 1 || (n % 2 == 0 && Solution(n / 2));
        }

        public bool Solution_Fast(int n)
        {
            if (n <= 0)
                return false;
            return (n & n - 1) == 0;
        }
    }
}
