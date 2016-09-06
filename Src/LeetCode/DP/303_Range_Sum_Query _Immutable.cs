using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class NumArray
    {
        private int[] sums;

        public NumArray(int[] nums)
        {
            if (nums != null && nums.Length > 0)
            {
                this.sums = new int[nums.Length];
                sums[0] = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    sums[i] = sums[i - 1] + nums[i];
                }
            }
        }

        public int SumRange(int i, int j)
        {
            var result = 0;
            if (i == 0)
                result = sums[j];
            else
                result = sums[j] - sums[i - 1];
            return result;
        }
    }
}
