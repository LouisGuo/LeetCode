using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MajorityElement
    {
        public int Solution(int[] nums)
        {
            var countDic = new Dictionary<int, int>();
            var lessCount = nums.Length / 2;
            if (nums != null)
            {
                if (nums.Length == 1)
                {
                    return nums[0];
                }
                else
                {
                    foreach (var num in nums)
                    {
                        if (countDic.ContainsKey(num))
                        {
                            countDic[num]++;
                            if (countDic[num] > lessCount)
                                return num;
                        }
                        else
                            countDic[num] = 1;
                    }
                }
            }
            throw new Exception();
        }
    }
}
