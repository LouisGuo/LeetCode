using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SingleNumber
    {
        public int Solution(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            var result = 0;
            foreach (var num in nums)
            {
                result ^= num;
            }
            return result;
        }
    }
}
