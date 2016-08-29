using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ClimbingStairs
    {
        public int Solution(int n)
        {
            if (n < 3)
                return n;
            return Solution(n - 1) + Solution(n - 2);
        }

        public int Solution_Fast(int n)
        {
            var middleResults = new int[n];
            for (int i = 0; i < 3 && i < n; i++)
            {
                middleResults[i] = i + 1;
            }
            return GetN(n, middleResults);
        }

        private int GetN(int n, int[] middleResults)
        {
            if (middleResults[n - 1] != 0)
                return middleResults[n - 1];
            else
            {
                var result = GetN(n - 1, middleResults) + GetN(n - 2, middleResults);
                middleResults[n - 1] = result;
                return result;
            }
        }

        public int Solution_Faster(int n)
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
