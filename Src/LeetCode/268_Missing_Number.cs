using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MissingNumber
    {
        public int Solution(int[] nums)
        {
            if (nums != null && nums.Length > 0)
            {
                var sum = nums.Length;
                for (int i = 0; i < nums.Length; i++)
                {
                    sum = sum + i - nums[i];
                }
                return sum;
            }
            return 0;
        }
    }
}
