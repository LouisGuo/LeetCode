using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindtheDifference
    {
        public char Solution(string s, string t)
        {
            if (s == null || t == null || s.Length != t.Length-1)
                return ' ';
            var flags = new int[26];
            foreach (var ch in s)
            {
                flags[(int)ch - 97]++;
            }
            foreach (var ch in t)
            {
                flags[(int)ch - 97]--;
            }
            for (int i = 0; i < flags.Length; i++)
            {
                if (flags[i] == 1)
                    return (char)(i + 97);
            }
            return ' ';
        }
    }
}
