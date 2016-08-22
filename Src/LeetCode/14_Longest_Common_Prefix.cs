using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestCommonPrefix
    {
        public string Sollution(string[] strs)
        {
            var commonPrefix = String.Empty;
            if (strs != null && strs.Length > 0)
            {
                for (int j = 0; j < strs[0].Length; j++)
                {
                    var ch = strs[0][j];
                    var isCommon = true;
                    for (int i = 0; i < strs.Length; i++)
                    {
                        if (strs[i] != null && strs[i].Length > j && strs[i][j].Equals(ch))
                        {
                            continue;
                        }
                        else
                        {
                            isCommon = false;
                            break;
                        }
                    }
                    if (isCommon)
                    {
                        commonPrefix += ch;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return commonPrefix;
        }
    }
}
