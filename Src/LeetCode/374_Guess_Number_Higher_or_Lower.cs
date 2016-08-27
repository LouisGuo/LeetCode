using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class GuessNumberHigherorLower
    {
        public int Sollution(int n)
        {
            var left = 1;
            var right = n;
            var middle = left + (right - left) / 2;
            while (left < right - 1)
            {
                var guessResult = guess(middle);
                if (guessResult == 1)
                {
                    right = middle;
                }
                else if (guessResult == -1)
                {
                    left = middle;
                }
                else
                {
                    return middle;
                }
                middle = left + (right - left) / 2;
            }
            return guess(left) == 0 ? left : right;
        }

        private int guess(int num)
        {
            var result = num - 6;
            if (result > 0)
                return 1;
            else if (result < 0)
                return -1;
            return 0;
        }
    }
}
