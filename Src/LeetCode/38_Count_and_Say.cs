using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CountandSay
    {
        public string Sollution(int n)
        {
            var result = "1";
            for (int i = 2; i <= n; i++)
            {
                result = Get(result);
            }
            return result;
        }

        public string Get(string n)
        {
            var result = String.Empty;
            var strN = n.ToString();
            var ch = strN[0];
            var count = 0;
            for (int i = 0; i < strN.Length; i++)
            {
                if (strN[i] == ch)
                    count++;
                else
                {
                    result = result + count + ch;
                    ch = strN[i];
                    count = 1;
                }
            }
            result = result + count + ch;
            return result;
        }
    }
}
