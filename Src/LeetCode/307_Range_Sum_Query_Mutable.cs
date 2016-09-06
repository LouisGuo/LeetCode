using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class NumArray1
    {
        private int[] sums;
        private int[] nums;

        public NumArray1(int[] nums)
        {
            this.nums = nums;
            ResetSums(0);
        }

        private void ResetSums(int start)
        {
            if (nums != null && nums.Length > 0)
            {
                this.sums = sums ?? new int[nums.Length];
                if (start == 0)
                {
                    sums[0] = nums[start++];
                }
                for (int i = start; i < nums.Length; i++)
                {
                    sums[i] = sums[i - 1] + nums[i];
                }
            }
        }

        public void Update(int i, int val)
        {
            this.nums[i] = val;
            this.ResetSums(i);
        }

        public int SumRange(int i, int j)
        {
            var result = 0;
            if (i == 0)
                result = sums[j];
            else
                result = sums[j] - sums[i - 1];
            return result;
        }
    }

    public class NumArray_Fast
    {
        private int[] sums;
        private int[] nums;

        public NumArray_Fast(int[] nums)
        {
            this.nums = nums;
            ResetSums(0);
        }

        private void ResetSums(int start)
        {
            if (nums != null && nums.Length > 0)
            {
                this.sums = sums ?? new int[nums.Length];
                if (start == 0)
                {
                    sums[0] = nums[start++];
                }
                for (int i = start; i < nums.Length; i++)
                {
                    sums[i] = sums[i - 1] + nums[i];
                }
            }
        }

        public void Update(int i, int val)
        {
            this.nums[i] = val;
            this.ResetSums(i);
        }

        public int SumRange(int i, int j)
        {
            var result = 0;
            if (i == 0)
                result = sums[j];
            else
                result = sums[j] - sums[i - 1];
            return result;
        }
    }
}
