using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LengthofLastWord
    {
        public int Sollution(string s)
        {
            var result = 0;
            if (s != null && !s.Equals(String.Empty))
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i].Equals(' ') && result == 0)
                        continue;
                    else if (!s[i].Equals(' '))
                        result++;
                    else
                        break;
                }
            }
            return result;
        }
    }
}
