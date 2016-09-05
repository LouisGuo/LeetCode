using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BulbSwitcher
    {
        public int Solution(int n)
        {
            var result = 0;
            if (n > 0)
            {
                var flags = new BitArray(n);
                flags.SetAll(true);
                for (int i = 1; i <= n; i++)
                {
                    for (int j = i; j < n; j += i + 1)
                    {
                        flags[j] = !flags[j];
                    }
                }
                foreach (bool flag in flags)
                {
                    if (flag)
                        result++;
                }
            }
            return result;
        }

        public int Solution_Fast(int n)
        {
            return (int)Math.Sqrt(n);
        }
        }
}
