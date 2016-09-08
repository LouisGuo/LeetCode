using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class HouseRobber
    {
        public int Solution(int[] nums)
        {
            var result = 0;
            if (nums != null && nums.Length > 0)
            {
                result = nums[0];
                var containn_1 = nums[0];
                var containNon_1 = 0;
                for (int i = 1; i < nums.Length; i++)
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
