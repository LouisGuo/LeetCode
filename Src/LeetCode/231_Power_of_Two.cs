using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PowerofTwo
    {
        public bool Sollution(int n)
        {
            if (n <= 0)
                return false;
            return n == 1 || (n % 2 == 0 && Sollution(n / 2));
        }

        public bool Sollution_Fast(int n)
        {
            if (n <= 0)
                return false;
            return (n & n - 1) == 0;
        }
    }
}
