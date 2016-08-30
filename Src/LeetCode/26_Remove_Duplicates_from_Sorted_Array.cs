using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveDuplicatesfromSortedArray
    {
        public int Solution(int[] nums)
        {
            var current = -1;
            if (nums != null && nums.Length > 0)
            {
                current = 0;
                var cursor = 1;
                while (cursor < nums.Length)
                {
                    if (nums[cursor] == nums[current])
                        cursor++;
                    else
                    {
                        nums[++current] = nums[cursor++];
                    }
                }
            }
            return current + 1;
        }
    }
}
