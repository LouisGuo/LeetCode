using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RotateArray
    {
        public void Sollution(int[] nums, int k)
        {
            if (k >= nums.Length)
                k = k % nums.Length;
            if (k > 0)
            {
                var temp = nums[nums.Length - 1];
                for (int i = nums.Length - 2; i >= 0; i--)
                {
                    nums[i + 1] = nums[i];
                }
                nums[0] = temp;
                k--;
                Sollution(nums, k);
            }
        }

        public void Sollution_Fast(int[] nums, int k)
        {
            if (k >= nums.Length)
                k = k % nums.Length;
            if (k != 0)
            {
                var movedCount = RotateInner(nums, k, 0);
                if (movedCount != nums.Length)
                {
                    for (int i = 1; i < nums.Length / movedCount; i++)
                    {
                        RotateInner(nums, k, i);
                    }
                }
            }
        }

        private int RotateInner(int[] nums, int k, int start)
        {
            var movedCount = 1;
            var oldIndex = start;
            var newIndex = k + start;
            var tempValue = nums[start];
            for (int i = 1; newIndex != start && i < nums.Length; i++)
            {
                var temp = nums[newIndex];
                nums[newIndex] = tempValue;
                oldIndex = newIndex;
                newIndex = oldIndex + k;
                if (newIndex > nums.Length - 1)
                    newIndex -= nums.Length;
                tempValue = temp;
                movedCount++;
            }
            nums[newIndex] = tempValue;
            return movedCount;
        }
    }
}
