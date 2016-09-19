using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class DecodeWays
    {
        public int Solution(string s)
        {
            var result = 0;
            if (!String.IsNullOrEmpty(s))
            {
                if (s.Length == 1)
                    result = 1;
                else
                {
                    var fn_1 = IsValid(s[0], s[1]) ? 2 : 1;
                    var fn_2 = 1;
                    result = fn_1;
                    for (int i = 2; i < s.Length; i++)
                    {
                        result = Math.Max(fn_1, fn_2 + (IsValid(s[i - 1], s[i]) ? 1 : 0));
                        fn_2 = fn_1;
                        fn_1 = result;
                    }
                }
            }
            return result;
        }

        private bool IsValid(char a, char b)
        {
            var value = int.Parse(a + "" + b);
            return value > 0 && value < 27;
        }
    }
}
