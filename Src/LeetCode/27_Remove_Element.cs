using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveElement
    {
        public int Solution(int[] nums, int val)
        {
            var head = 0;
            var tail = nums.Length - 1;
            while (head <= tail)
            {
                while (head < nums.Length && nums[head] != val)
                {
                    head++;
                }
                while (tail > -1 && nums[tail] == val)
                {
                    tail--;
                }
                if (head < tail)
                {
                    var temp = nums[tail];
                    nums[tail] = nums[head];
                    nums[head] = temp;
                }
            }
            return head;
        }
    }
}
