using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FirstBadVersion
    {
        public int Sollution(int n)
        {
            while (--n > 0)
            {
                if (!IsBadVersion(n))
                    return n + 1;
            }
            return 1;
        }

        public int Sollution_Fast(int n)
        {
            double left = 1d;
            double right = n;
            int middle = (int)(left / 2 + right / 2);
            while (left < right - 1)
            {
                if (IsBadVersion(middle))
                {
                    right = middle;
                }
                else
                {
                    left = middle;
                }
                middle = (int)(left / 2 + right / 2);
            }
            return IsBadVersion((int)left) ? (int)left : (int)++left;
        }

        protected bool IsBadVersion(int version)
        {
            return version >= 1702766719;
        }
    }
}
