using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int Sollution(string s)
        {
            if (s == null || s.Length == 0)
                return 0;
            var maxValue = 0;
            var minValue = 0;
            foreach (var ch in s)
            {
                if (ch > maxValue)
                    maxValue = ch;
                else if (ch < minValue)
                    minValue = ch;
            }
            var max = 1;
            var flags = new BitArray(maxValue - minValue + 1);
            for (int i = 0; i < s.Length; i++)
            {
                var count = 0;
                flags = new BitArray(maxValue - minValue + 1);
                for (int j = i; j < s.Length; j++)
                {
                    var index = s[j] - minValue;
                    if (!flags[index])
                    {
                        flags[index] = true;
                        count++;
                        if (j == s.Length - 1)
                        {
                            if (count > max)
                            {
                                max = count;
                            }
                            return max;
                        }
                    }
                    else
                    {
                        if (count > max)
                        {
                            max = count;
                        }
                        while (i < j && s[i] != s[j])
                        {
                            i++;
                        }
                        break;
                    }
                }
            }
            return max;
        }

        public int Sollution_Fast(string s)
        {
            if (s == null || s.Length == 0)
                return 0;
            var maxValue = 0;
            var minValue = 0;
            foreach (var ch in s)
            {
                if (ch > maxValue)
                    maxValue = ch;
                else if (ch < minValue)
                    minValue = ch;
            }
            var max = 1;
            var flags = new BitArray(maxValue - minValue + 1);
            var left = 0;
            var right = 0;
            while (left <= right && right < s.Length)
            {
                if (!flags[s[right - minValue]])
                {
                    var currentCount = right - left + 1;
                    if (currentCount > max)
                        max = currentCount;
                    flags[s[right - minValue]] = true;
                    right++;
                }
                else
                {

                    flags[s[left]] = false;
                    left++;
                }
            }
            return max;
        }
    }
}
