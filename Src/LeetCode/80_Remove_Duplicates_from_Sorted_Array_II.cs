using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveDuplicatesfromSortedArrayII
    {
        public int Solution(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            else if (nums.Length < 3)
                return nums.Length;
            else
            {
                var result = 0;
                var hasTwo = false;
                for (int current = 1; current < nums.Length; current++)
                {
                    if (nums[current] == nums[result])
                    {
                        if (!hasTwo)
                        {
                            hasTwo = true;
                            nums[++result] = nums[current];
                        }
                    }
                    else
                    {
                        hasTwo = false;
                        nums[++result] = nums[current];
                    }
                }
                return ++result;
            }
        }
    }
}
