using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MaximumSubarray
    {
        public int Solution(int[] nums)
        {
            var result = 0;
            if (nums != null && nums.Length > 0)
            {
                result = nums[0];
                var fn_1 = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    fn_1 = Math.Max(nums[i], fn_1 + nums[i]);
                    result = Math.Max(fn_1, result);
                }
            }
            return result;
        }
    }
}
