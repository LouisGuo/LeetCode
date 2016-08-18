using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseString
    {
        public string Sollution(string s)
        {
            return new String(s.ToArray().Reverse().ToArray());
        }

        public string Sollution_Fast(string s)
        {
            if (s == null || s.Length < 2)
                return s;
            var result = new StringBuilder(s.Length, s.Length);
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result.Append(s[i]);
            }
            return result.ToString();
        }
    }
}
