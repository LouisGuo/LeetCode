using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class HouseRobberII
    {
        public int Solution(int[] nums)
        {
            var result = 0;
            if (nums != null && nums.Length > 0)
            {
                if (nums.Length == 1)
                    result = nums[0];
                else if (nums.Length == 2)
                    result = Math.Max(nums[0], nums[1]);
                else
                {
                    var contain1 = GetN(nums, 2, nums.Length - 2) + nums[0];
                    var containNo1 = GetN(nums, 1, nums.Length - 1);
                    result = Math.Max(contain1, containNo1);
                }

            }
            return result;
        }

        private int GetN(int[] nums, int start, int end)
        {
            var result = 0;
            if (nums != null && nums.Length > start && end >= start)
            {
                result = nums[start];
                var containn_1 = nums[start];
                var containNon_1 = 0;
                for (int i = start + 1; i <= end; i++)
                {
                    containn_1 = containNon_1 + nums[i];
                    containNon_1 = result;
                    result = Math.Max(containNon_1, containn_1);
                }
            }
            return result;
        }
    }
}
