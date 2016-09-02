using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Permutations
    {
        public IList<IList<int>> Solution(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums != null && nums.Length > 0)
            {
                result.Add(new List<int>() { nums[nums.Length - 1] });
                for (int i = nums.Length - 2; i > -1; i--)
                {
                    GetN(result, nums[i]);
                }
            }
            return result;
        }

        private void GetN(IList<IList<int>> result, int num)
        {
            var listLength = result[0].Count + 1;
            var resultLength = result.Count;
            for (int i = 1; i < listLength; i++)
            {
                for (int j = 0; j < resultLength; j++)
                {
                    var temp = new List<int>();
                    for (int inner = 0; inner < listLength - 1; inner++)
                    {
                        temp.Add(result[j][inner]);
                    }
                    temp.Insert(i, num);
                    result.Add(temp);
                }
            }
            for (int i = 0; i < resultLength; i++)
            {
                result[i].Insert(0, num);
            }
        }
    }
}
