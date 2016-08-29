using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AddDigits
    {
        public int Solution(int num)
        {
            if (num < 10)
                return num;
            while (num >= 10)
            {
                var tempNum = 0;
                while (num != 0)
                {
                    tempNum += num % 10;
                    num /= 10;
                }
                num = tempNum;
            }
            return num;
        }

        public int Solution_Fast(int num)
        {
            if (num < 10)
                return num;
            while (num >= 10)
            {
                var tempNum = 0;
                while (num != 0)
                {
                    tempNum += num % 10;
                    num /= 10;
                }
                num = tempNum;
            }
            return num;
        }
    }
}
