using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ClimbingStairs
    {
        public int Sollution(int n)
        {
            if (n < 3)
                return n;
            return Sollution(n - 1) + Sollution(n - 2);
        }

        public int Sollution_Fast(int n)
        {
            if (n < 3)
                return n;
            var fn_2 = 1;
            var fn_1 = 2;
            for (int i = 4; i <= n; i++)
            {
                var temp = fn_2 + fn_1;
                fn_2 = fn_1;
                fn_1 = temp;
            }
            return fn_1 + fn_2;
        }
    }
}
