using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class JumpGame
    {
        public bool Solution(int[] nums)
        {
            if (nums == null || nums.Length <= 1)
                return true;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    var canJump = false;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if ((i != nums.Length - 1 && nums[j] > i - j) || (i == nums.Length - 1 && nums[j] >= i - j))
                        {
                            canJump = true;
                            break;
                        }
                    }
                    if (!canJump)
                        return false;
                }
            }
            return true;
        }
    }
}
