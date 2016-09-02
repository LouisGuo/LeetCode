using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ImplementstrStr
    {
        public int Solution(string haystack, string needle)
        {
            if (haystack != null && needle != null && haystack.Length >= needle.Length)
            {
                if (needle.Length == 0)
                    return 0;
                var endIndex = haystack.Length - needle.Length;
                for (int i = 0; i <= endIndex; i++)
                {
                    if (haystack[i] == needle[0])
                    {
                        var contains = true;
                        for (int j = 0; j < needle.Length; j++)
                        {
                            if (needle[j] != haystack[i + j])
                            {
                                contains = false;
                                break;
                            }
                        }
                        if (contains)
                            return i;
                    }
                }

            }
            return -1;
        }
    }
}
