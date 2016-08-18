using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /*
     * Given a non negative integer number num. For every numbers i in the range 0 ≤ i ≤ num calculate the number of 1's in their binary representation and return them as an array.
     * Example:
     *     For num = 5 you should return [0,1,1,2,1,2].
     * 
     * Follow up:
     *     It is very easy to come up with a solution with run time O(n*sizeof(integer)). But can you do it in linear time O(n) /possibly in a single pass?
     *     Space complexity should be O(n).
     *     Can you do it like a boss? Do it without using any builtin function like __builtin_popcount in c++ or in any other language.
     * 
     */
    public class Counting_Bits
    {
        public int[] Sollution(int num)
        {
            var result = new int[num + 1];
            var numCount = (int)Math.Log(num + 1, 2) + 1;
            var flags = new bool[numCount];
            for (int i = 1; i <= num; i++)
            {
                var lastIncrease = flags[0];
                flags[0] = !flags[0];
                for (int j = 1; lastIncrease && j < flags.Length; j++)
                {
                    lastIncrease = flags[j];
                    flags[j] = !flags[j];
                }
                result[i] = flags.Count(f => f);
            }
            return result;
        }

        public int[] Sollution_Fast(int num)
        {
            var result = new int[num + 1];
            if (num > 0)
                result[1] = 1;
            if (num > 1)
            {
                var known = 2;
                while (known <= num)
                {
                    for (int i = 0; known + i <= num && i < known; i++)
                    {
                        result[known + i] = result[i] + 1;
                    }
                    known *= 2;
                }
            }
            return result;
        }
    }
}
