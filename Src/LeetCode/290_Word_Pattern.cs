using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class WordPattern
    {
        public bool Solution(string pattern, string str)
        {
            var splits = str.Split(' ');
            if (pattern.Length != splits.Length)
                return false;
            var patternSet = new Dictionary<int, int>();
            var strSet = new Dictionary<int, int>();
            for (int i = 0; i < splits.Length; i++)
            {
                var patternHasKey = patternSet.ContainsKey(pattern[i].GetHashCode());
                var strHasKey = strSet.ContainsKey(splits[i].GetHashCode());
                var hasNoKey = !patternHasKey && !strHasKey;
                var valid = (hasNoKey) ||
                    (patternHasKey && strHasKey 
                    && patternSet[pattern[i].GetHashCode()] == strSet[splits[i].GetHashCode()]);
                if (valid)
                {
                    if (hasNoKey)
                    {
                        patternSet[pattern[i].GetHashCode()] = 1;
                        strSet[splits[i].GetHashCode()] = 1;
                    }
                    else
                    {
                        patternSet[pattern[i].GetHashCode()]++;
                        strSet[splits[i].GetHashCode()]++;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
