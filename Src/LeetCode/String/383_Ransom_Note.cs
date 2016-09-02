using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RansomNote
    {
        public bool Solution(string ransomNote, string magazine)
        {
            var sb = new StringBuilder(magazine);
            foreach (var ch in ransomNote)
            {
                var contains = false;
                for (int i = 0; i < sb.Length; i++)
                {
                    if (sb[i].Equals(ch))
                    {
                        sb.Remove(i, 1);
                        contains = true;
                        break;
                    }
                }
                if (!contains)
                    return false;
            }
            return true;
        }
    }
}
