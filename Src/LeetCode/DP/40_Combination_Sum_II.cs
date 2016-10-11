using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CombinationSumII
    {
        public IList<IList<int>> Solution(int[] candidates, int target)
        {
            candidates.OrderBy(c => c);
            var result = new Dictionary<int, IList<IList<int>>>();
            for (int i = 0; i < candidates.Length; i++)
            {
                if (candidates[i] == target)
                {
                    if (!result.ContainsKey(target))
                        result[target] = new List<IList<int>>();
                    result[target].Add(new List<int> { target });
                }
                else if (candidates[i] < target)
                {
                    foreach (var item in result.OrderByDescending(k => k.Key))
                    {
                        var current = item.Key + candidates[i];
                        if (current <= target)
                        {
                            if (!result.ContainsKey(current))
                                result[current] = new List<IList<int>>();
                            foreach (var list in item.Value)
                            {
                                var temp = new List<int> { candidates[i] };
                                temp.AddRange(list);
                                result[current].Add(temp);
                            }
                        }
                    }
                    if (!result.ContainsKey(candidates[i]))
                        result[candidates[i]] = new List<IList<int>>();
                    if (i > 0 && candidates[i] != candidates[i - 1])
                        result[candidates[i]].Add(new List<int> { candidates[i] });
                }
            }
            return result[target];
        }
    }
}
