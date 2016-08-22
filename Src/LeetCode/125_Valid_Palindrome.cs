using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidPalindrome
    {
        public bool Sollution(string s)
        {
            if (s == null || s.Length < 2)
                return true;
            s = s.ToUpper();
            var left = 0;
            var tail = s.Length - 1;
            while (left < tail)
            {
                while (left < tail && !((s[left] > 47 && s[left] < 58) || (s[left] > 64 && s[left] < 91)))
                {
                    left++;
                }
                while (left < tail && !((s[tail] > 47 && s[tail] < 58) || (s[tail] > 64 && s[tail] < 91)))
                {
                    tail--;
                }
                if (left != tail)
                {
                    var valid = ((s[tail] > 47 && s[tail] < 58) || (s[tail] > 64 && s[tail] < 91));
                    valid = valid && (s[left] == s[tail]);
                    if (!valid)
                        return false;
                }
                tail--;
                left++;
            }
            return true;
        }

        public bool Sollution_Fast(string s)
        {
            if (s == null || s.Length < 2)
                return true;
            s = s.ToUpper();
            var validList = s.Where(ch => (ch > 47 && ch < 58) || (ch > 64 && ch < 91)).ToArray();
            var left = 0;
            var tail = validList.Length - 1;
            while (left < tail)
            {
                if (validList[left] == validList[tail])
                {
                    tail--;
                    left++;
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
