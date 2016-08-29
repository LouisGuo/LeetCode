using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ExcelSheetColumnNumber
    {
        public int Solution(string s)
        {
            if (s == null || s.Length == 0)
                return 0;
            var result = 0;
            var level = 1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result = result + level * ((int)s[i] - 64);
                level *= 26;
            }
            return result;
        }
    }
}
