using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsSubsequence
    {
        public bool Solution(string s, string t)
        {
            if (t != null && s != null && t.Length >= s.Length)
            {
                if (s.Length == 0)
                    return true;
                else
                {
                    var tCurrent = 0;
                    var sCurrent = 0;
                    while (tCurrent < t.Length && sCurrent < s.Length)
                    {
                        while (tCurrent < t.Length && t[tCurrent] != s[sCurrent])
                        {
                            tCurrent++;
                        }
                        if (tCurrent < t.Length)
                        {
                            tCurrent++;
                            sCurrent++;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    return sCurrent >= s.Length;
                }
            }
            return false;
        }
    }
}
