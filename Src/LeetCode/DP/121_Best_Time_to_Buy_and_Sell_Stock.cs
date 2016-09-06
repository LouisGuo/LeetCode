using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BestTimetoBuyandSellStock
    {
        public int Solution(int[] prices)
        {
            var result = 0;
            if (prices != null && prices.Length > 1)
            {
                var min = prices[0];
                for (int i = 1; i < prices.Length; i++)
                {
                    if (prices[i] > min)
                        result = Math.Max(result, prices[i] - min);
                    else
                        min = prices[i];
                }
            }
            return result;
        }
    }
}
