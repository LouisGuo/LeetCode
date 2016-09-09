using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class KthLargestElementinanArray
    {
        public int Solution(int[] nums, int k)
        {
            nums = nums.OrderByDescending(n => n).ToArray();
            return nums[k - 1];
        }

        public int Solution_Real(int[] nums, int k)
        {
            var result = 0;
            if (nums != null && nums.Length > 1 && k <= nums.Length)
            {
                k = nums.Length - k;
                var left = 0;
                var right = nums.Length - 1;
                result = RandomQuickSelect(nums, left, right);
                while (k != result)
                {
                    if (k > result)
                    {
                        left = result + 1;
                    }
                    else
                    {
                        right = result - 1;
                    }
                    result = RandomQuickSelect(nums, left, right);
                }
            }
            return nums[result];
        }

        private int RandomQuickSelect(int[] nums, int left, int right)
        {
            if (left < right)
            {
                var flag = left;
                left++;
                while (left < right)
                {
                    while (left < right && nums[left] < nums[flag])
                    {
                        left++;
                    }
                    while (left < right && nums[right] > nums[flag])
                    {
                        right--;
                    }
                    if (left < right)
                    {
                        nums[left] = nums[right] + nums[left];
                        nums[right] = nums[left] - nums[right];
                        nums[left] = nums[left] - nums[right];
                        left++;
                        right--;
                    }
                }
                if (nums[left] > nums[flag])
                    left--;
                var middle = nums[flag];
                for (int i = flag; i < left; i++)
                {
                    nums[i] = nums[i + 1];
                }
                nums[left] = middle;
            }
            return left;
        }
    }
}
