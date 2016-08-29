using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidAnagram
    {
        public bool Solution(string s, string t)
        {
            if (s != null && t != null && s.Length == t.Length)
            {
                var charDic = new Dictionary<char, int>();
                foreach (var ch in s)
                {
                    if (charDic.ContainsKey(ch))
                        charDic[ch]++;
                    else
                        charDic[ch] = 1;
                }
                foreach (var ch in t)
                {
                    if (charDic.ContainsKey(ch))
                    {
                        charDic[ch]--;
                        if (charDic[ch] < 0)
                            return false;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
