using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ContainsDuplicateII
    {
        public bool Sollution(int[] nums, int k)
        {
            if (nums.Length > 1)
            {
                var current = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    current = nums[i];
                    var currentMax = i + k;
                    for (int j = i + 1; j <= currentMax && j < nums.Length; j++)
                    {
                        if (current == nums[j])
                            return true;
                    }
                }
            }
            return false;
        }

        public bool Sollution_Fast(int[] nums, int k)
        {
            if (nums.Length > 1)
            {
                var lastIndexs = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (lastIndexs.ContainsKey(nums[i]) && lastIndexs[nums[i]] + k >= i)
                    {
                        return true;
                    }
                    else
                    {
                        lastIndexs[nums[i]] = i;
                    }
                }
            }
            return false;
        }
    }
}
