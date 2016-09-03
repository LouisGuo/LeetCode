using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeSortedArray
    {
        public void Solution(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m + n - 1; i >= n; i--)
            {
                nums1[i] = nums1[i - n];
            }
            var current = 0;
            var head1 = n;
            var head2 = 0;
            while (head1 < m + n && head2 < n)
            {
                if (nums1[head1] < nums2[head2])
                {
                    nums1[current++] = nums1[head1++];
                }
                else
                {
                    nums1[current++] = nums2[head2++];
                }
            }
            while (head2 < n)
            {
                nums1[current++] = nums2[head2++];
            }
        }
    }
}
