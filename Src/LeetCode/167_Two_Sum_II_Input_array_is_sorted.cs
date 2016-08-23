using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TwoSumIIInputarrayissorted
    {
        public int[] Sollution(int[] nums, int target)
        {
            var result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i + 1, j + 1 };
                }
            }
            return result;
        }

        public int[] Sollution_Fast(int[] nums, int target)
        {
            var left = 0;
            var tail = nums.Length - 1;
            var current = nums[left] + nums[tail];
            while (current != target && left <= tail)
            {
                if (current > target)
                {
                    current = current - nums[tail--] + nums[tail];
                }
                else
                {
                    current = current - nums[left++] + nums[left];
                }
            }
            return new int[] { ++left, ++tail };
        }

    }
}
