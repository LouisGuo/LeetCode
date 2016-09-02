using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SearchforaRange
    {
        public int[] Solution_Fast(int[] nums, int target)
        {
            if (nums != null && nums.Length > 0 && nums[0] <= target && nums[nums.Length - 1] >= target)
            {
                var left = 0;
                var right = nums.Length - 1;
                var middle = left + (right - left) / 2;
                while (left < right - 1)
                {
                    if (nums[middle] < target)
                    {
                        left = middle + 1;
                    }
                    else if (nums[middle] > target)
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle;
                        right = middle;
                        while (right < nums.Length && nums[right] == target)
                        {
                            right++;
                        }
                        while (left > -1 && nums[left] == target)
                        {
                            left--;
                        }
                        return new int[] { ++left, --right };
                    }
                    middle = left + (right - left) / 2;
                }
                if (nums[left] == target && nums[right] == target)
                    return new int[] { left, right };
                else if (nums[left] == target && nums[right] != target)
                    return new int[] { left, left };
                else if (nums[left] != target && nums[right] == target)
                    return new int[] { right, right };
                else
                    return new int[] { -1, -1 };
            }
            return new int[] { -1, -1 };
        }

        public int[] Solution(int[] nums, int target)
        {
            if (nums != null && nums.Length > 0 && nums[0] <= target && nums[nums.Length - 1] >= target)
            {
                var left = 0;
                var right = nums.Length - 1;
                var middle = left + (right - left) / 2;
                while (nums[left] < nums[right])
                {
                    if (nums[middle] < target)
                    {
                        left = middle + 1;
                    }
                    else if (nums[middle] > target)
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        if (nums[left] != target)
                            left++;
                        if (nums[right] != target)
                            right--;
                    }
                    middle = left + (right - left) / 2;
                }
                if (nums[left] == target && nums[right] == target)
                    return new int[] { left, right };
                else
                    return new int[] { -1, -1 };
            }
            return new int[] { -1, -1 };
        }
    }
}
