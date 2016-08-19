using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MoveZeroes
    {
        public void Sollution(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return;
            var swapIndex = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 0)
                {
                    for (swapIndex = swapIndex + 1; swapIndex < nums.Length; swapIndex++)
                    {
                        if (nums[swapIndex] != 0)
                            break;
                    }
                    if (swapIndex < nums.Length)
                    {
                        nums[i] = nums[swapIndex];
                        nums[swapIndex] = 0;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    swapIndex++;
                }
            }
        }
    }
}
