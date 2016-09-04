using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IntersectionofTwoArrays
    {
        public int[] Solution(int[] nums1, int[] nums2)
        {
            return nums1.Intersect(nums2).Distinct().ToArray();
        }
    }
}
