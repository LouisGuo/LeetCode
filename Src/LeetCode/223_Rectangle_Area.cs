using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RectangleArea
    {
        public int Solution(int A, int B, int C, int D, int E, int F, int G, int H)
        {
            var a = Math.Max(A, E);
            var b = Math.Max(B, F);
            var c = Math.Min(C, G);
            var d = Math.Min(D, H);
            var total = (C - A) * (D - B) + (G - E) * (H - F);
            if (c > a && d > b)
                total -= (c - a) * (d - b);
            return total;
        }
    }
}
