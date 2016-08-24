﻿using System;
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
            if (k > 0)
            {
                var oldIndex = 0;
                var newIndex = nums.Length - k;
                var tempValue = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    var temp = nums[newIndex];
                    nums[newIndex] = tempValue;
                    oldIndex = newIndex;
                    newIndex = (oldIndex - k >= 0) ? (oldIndex - k) : (nums.Length + oldIndex - k);
                    tempValue = temp;
                }
                nums[newIndex] = tempValue;
            }
        }
    }
}