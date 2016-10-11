using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CombinationSum
    {
        public IList<IList<int>> Solution(int[] candidates, int target)
        {
            candidates.OrderBy(c => c);
            var result = new IList<IList<int>>[target];
            for (int i = 1; i < target + 1; i++)
            {
                var addList = new List<IList<int>>();
                for (int index = 0; index < candidates.Length; index++)
                {
                    if (i == candidates[index])
                        addList.Add(new List<int> { i });
                    else if (i > candidates[index])
                    {
                        var need = i - candidates[index];
                        for (int cursor = 0; cursor < result[need - 1].Count; cursor++)
                        {
                            if (result[need - 1][cursor][0] >= candidates[index])
                            {
                                var tem = new List<int> { candidates[index] };
                                tem.AddRange(result[need - 1][cursor]);
                                addList.Add(tem);
                            }
                        }
                    }
                }
                result[i - 1] = addList;
            }
            return result[target - 1];
        }
    }
}
