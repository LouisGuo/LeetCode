using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RomantoInteger
    {
        public int Solution(string s)
        {
            var result = 0;
            if (s != null && s.Length > 0)
            {
                var charDic = new Dictionary<char, int>()
                {
                    {'I', 1},
                    {'V', 5},
                    {'X', 10},
                    {'L', 50},
                    {'C', 100},
                    {'D', 500},
                    {'M', 1000},
                };
                for (int i = 0; i < s.Length; i++)
                {
                    if (i < s.Length - 1 && charDic[s[i]] < charDic[s[i + 1]])
                    {
                        result -= charDic[s[i]];
                    }
                    else
                    {
                        result += charDic[s[i]];
                    }
                }
            }
            return result;
        }
    }
}
