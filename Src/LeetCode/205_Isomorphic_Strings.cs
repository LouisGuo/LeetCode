using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsomorphicStrings
    {
        public bool Solution(string s, string t)
        {
            if (s == null && t == null)
                return true;
            else if (s != null && t != null && s.Length == t.Length)
            {
                var sDic = new Dictionary<char, char>();
                var tDic = new HashSet<char>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (!sDic.ContainsKey(s[i]))
                    {
                        if (tDic.Contains(t[i]))
                            return false;
                        sDic[s[i]] = t[i];
                        tDic.Add(t[i]);
                    }
                    else
                    {
                        if (sDic[s[i]] != t[i])
                            return false;
                    }
                }
                return true;
            }
            else
                return false;
        }
    }
}
