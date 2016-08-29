using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ContainsDuplicate
    {
        public bool Solution(int[] nums)
        {
            if (nums != null && nums.Length > 1)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] == nums[j])
                            return true;
                    }
                }
            }
            return false;
        }

        public bool Solution_Fast(int[] nums)
        {
            return nums != null && nums.Length != nums.Distinct().Count();
        }

        public bool Solution_Faster(int[] nums)
        {
            if (nums != null && nums.Length > 1)
            {
                var min = 0;
                var max = 0;
                foreach (var num in nums)
                {
                    if (num < min)
                        min = num;
                    else if (num > max)
                        max = num;
                }
                var bitArray = new BitArray(max - min + 1);
                foreach (var num in nums)
                {
                    var index = num - min;
                    if (bitArray[index])
                        return true;
                    else
                        bitArray[index] = true;
                }
            }
            return false;
        }

        public bool Solution_FasterEvenMore(int[] nums)
        {
            if (nums != null && nums.Length > 1)
            {
                var min = 0;
                var max = 0;
                foreach (var num in nums)
                {
                    if (num < min)
                        min = num;
                    else if (num > max)
                        max = num;
                }
                var bitArray = new BitArray(max - min + 1);
                if (bitArray.Length >= nums.Length)
                {
                    foreach (var num in nums)
                    {
                        var index = num - min;
                        if (bitArray[index])
                            return true;
                        else
                            bitArray[index] = true;
                    }
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
