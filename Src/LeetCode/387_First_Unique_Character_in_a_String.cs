using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FirstUniqueCharacterinaString
    {
        public int Solution(string s)
        {
            if (s != null)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    bool isUnique = true;
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (i != j && s[i].Equals(s[j]))
                        {
                            isUnique = false;
                            break;
                        }
                    }
                    if (isUnique)
                        return i;
                }
            }
            return -1;
        }

        public int Solution_Fast(string s)
        {
            if (s != null && !s.Equals(String.Empty))
            {
                var charConut = new int[Char.MaxValue];
                foreach (int ch in s)
                {
                    charConut[ch]++;
                }
                for (int i = 0; i < s.Length; i++)
                {
                    if (charConut[s[i]] == 1)
                        return i;
                }
            }
            return -1;
        }
    }
}
