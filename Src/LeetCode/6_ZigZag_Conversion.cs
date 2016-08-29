using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ZigZagConversion
    {
        public string Solution(string s, int numRows)
        {
            if (s != null && s.Length > 2 && numRows > 1)
            {
                var result = new StringBuilder();
                for (int i = 0; i < numRows; i++)
                {
                    
                }
                return result.ToString();
            }
            else
            {
                return s;
            }
        }
    }
}
