using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SearchInsertPosition
    {
        public int Solution(int[] nums, int target)
        {
            if (nums != null && nums.Length > 0)
            {
                var left = 0;
                var right = nums.Length - 1;
                var middle = left + (right - left) / 2;
                if (target < nums[left])
                    return left;
                else if (target > nums[right])
                    return ++right;
                else
                {
                    while (left < right - 1)
                    {
                        if (nums[middle] > target)
                        {
                            right = middle;
                        }
                        else if (nums[middle] < target)
                        {
                            left = middle;
                        }
                        else
                        {
                            return middle;
                        }
                        middle = left + (right - left) / 2;
                    }
                    if (nums[left] < target)
                        left++;
                    return left;
                }
            }
            return 0;
        }
    }
}
