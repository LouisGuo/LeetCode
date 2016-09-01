using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SortColors
    {
        public void Solution(int[] nums)
        {
            if (nums != null && nums.Length > 1)
            {
                var sums = new int[3];
                foreach (var num in nums)
                {
                    sums[num]++;
                }
                for (int i = 0; i < sums[0]; i++)
                {
                    nums[i] = sums[0];
                }
                for (int i = sums[0]; i < sums[1] + sums[0]; i++)
                {
                    nums[i] = sums[1];
                }
                for (int i = sums[1] + sums[0]; i < nums.Length; i++)
                {
                    nums[i] = sums[2];
                }
            }
        }
    }
}
