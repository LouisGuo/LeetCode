using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MaximumProductSubarray
    {
        public int Solution(int[] nums)
        {
            var result = 0;
            if (nums != null && nums.Length > 0)
            {
                result = nums[0];
                var maxn_1 = result;
                var minn_1 = result;
                for (int i = 1; i < nums.Length; i++)
                {
                    var max = maxn_1 * nums[i];
                    var min = minn_1 * nums[i];
                    maxn_1 = Math.Max(nums[i], Math.Max(max, min));
                    minn_1 = Math.Min(nums[i], Math.Min(max, min));
                    result = Math.Max(result, maxn_1);
                }
            }
            return result;
        }
    }
}
